using PensionConsultants.Data.Access;
using PensionConsultants.Data.Utilities;
using TicketTracker.Business.Components;
using TicketTracker.Business.Workflows;

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace TicketTracker.Business.Entities
{
    public class Ticket : IBusinessEntity
    {
        public Guid TicketId { get; private set; }
        public Guid OwnerId;
        public Guid CreatedBy { get; private set; }
        public Guid ModifiedBy;
        public Guid RequestedBy;
        public Guid PriorityLevelId;
        public Guid? StatusId;

        public string SubjectValue;
        public string DescriptionValue;
        public string Type;

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public string Purpose;

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This is a brief description of the organization, and the project objectives.
        /// The project purpose, and motives for the development of the precise scope of
        /// work, is explained. This portion provides a brief rationale for the scope of
        /// work, and the goals expected to be achieved. This assists the vendor to
        /// understand the company, and the kind of tasks being undertaken. This section
        /// is not very extensive, but the important details are to be included to
        /// ensure a clear definition of the objectives.
        /// </remarks>
        public string Objective;

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Deliverables, including their technical specifications in adequate detail,
        /// are provided to ensure their provision according to the precise project
        /// requirement. A change in program may require the design of application, or
        /// a brief description of the effort needed for the development of software.
        /// The level of details depends upon the project's complexity. The scope of
        /// work clarifies what is required, and the environment under which the project
        /// is functioning. The policies of the organization, and the effect on objectives
        /// by achieving the scope of work, are explained. The methodology to be applied
        /// for responding to the requirements is explained. The vendor is allowed some
        /// flexibility in the preparation of project solution. For example, a scope of
        /// work concerning the manufacture of doors will include the kind of doors,
        /// hardware to be provided by the contractor, installation arrangements,
        /// provision of transport, and other related work conditions.
        /// </remarks>
        public string Deliverables;

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This is an important aspect of the scope of work since the objectives are
        /// influenced by the schedule. Progress, or other reports required from the
        /// vendor must be included, otherwise he may not be bound to provide, if required.
        /// </remarks>
        public string Schedule;

        public decimal? PriorityOverride;
        public decimal? PriorityCompetition;
        public decimal? PriorityCompliance;
        public decimal? PriorityEfficiency;
        public decimal? PriorityFirmGoals;
        public decimal? PriorityService;
        public decimal? PriorityTeamGoals;

        public decimal? EstimatedHours;

        /// <summary>
        /// Hours completed against the ticket. This is calculated upon instanciation of ticket object
        /// and is not a database field.
        /// </summary>
        public decimal? CompletedHours;

        public DateTime CreatedOn { get; private set; }
        public DateTime ModifiedOn;
        public DateTime? DateAssigned;
        public DateTime? TargetDate;
        public DateTime? DateCompleted;

        public int StateCode;

        public bool ExistingRecord { get; private set; }

        private bool ErrorOccurred;
        private string ErrorMessage;

        internal Ticket InstantiatedTicket { get; set; }

        public Ticket()
        {
            ExistingRecord = false;

            TicketId = Guid.NewGuid();
            StatusId = new Guid("06C16F0F-1ED1-4FEA-91A3-1B8E5DD44E6A");
            StateCode = 0;
        }

        public Ticket(Guid _ticketId)
        {
            ExistingRecord = true;

            DataTable _dataTable = GetDetails(_ticketId);
            DataRow _dataRow = _dataTable.Rows[0];

            Guid _createdBy;
            DateTime _createdOn;

            TicketId = _ticketId;

            SubjectValue = _dataRow["SubjectValue"].ToString();
            DescriptionValue = _dataRow["DescriptionValue"].ToString();
            Type = _dataRow["Type"].ToString();

            StringParser.Parse(_dataRow["OwnerId"].ToString(), out OwnerId);
            StringParser.Parse(_dataRow["CreatedBy"].ToString(), out _createdBy);
            StringParser.Parse(_dataRow["ModifiedBy"].ToString(), out ModifiedBy);
            StringParser.Parse(_dataRow["EstimatedHours"].ToString(), out EstimatedHours);
            StringParser.Parse(_dataRow["CompletedHours"].ToString(), out CompletedHours);
            StringParser.Parse(_dataRow["PriorityLevelId"].ToString(), out PriorityLevelId);
            StringParser.Parse(_dataRow["StatusId"].ToString(), out StatusId);
            StringParser.Parse(_dataRow["RequestedBy"].ToString(), out RequestedBy);
            StringParser.Parse(_dataRow["PriorityOverride"].ToString(), out PriorityOverride);
            StringParser.Parse(_dataRow["PriorityCompetition"].ToString(), out PriorityCompetition);
            StringParser.Parse(_dataRow["PriorityCompliance"].ToString(), out PriorityCompliance);
            StringParser.Parse(_dataRow["PriorityEfficiency"].ToString(), out PriorityEfficiency);
            StringParser.Parse(_dataRow["PriorityFirmGoals"].ToString(), out PriorityFirmGoals);
            StringParser.Parse(_dataRow["PriorityService"].ToString(), out PriorityService);
            StringParser.Parse(_dataRow["PriorityTeamGoals"].ToString(), out PriorityTeamGoals);
            StringParser.Parse(_dataRow["CreatedOn"].ToString(), out _createdOn);
            StringParser.Parse(_dataRow["ModifiedOn"].ToString(), out ModifiedOn);
            StringParser.Parse(_dataRow["DateAssigned"].ToString(), out DateAssigned);
            StringParser.Parse(_dataRow["TargetDate"].ToString(), out TargetDate);
            StringParser.Parse(_dataRow["DateCompleted"].ToString(), out DateCompleted);
            StringParser.Parse(_dataRow["StateCode"].ToString(), out StateCode);

            CreatedBy = _createdBy;
            CreatedOn = _createdOn;

            InstantiatedTicket = (Ticket)this.MemberwiseClone();
        }

        public void SaveRecordToDatabase(Guid modifiedBy)
        {
            if (ExistingRecord)
            {
                UpdateDatabaseRecord(modifiedBy);
            }
            else
            {
                InsertDatabaseRecord(modifiedBy);
            }
        }

        private void UpdateDatabaseRecord(Guid modifiedBy)
        {
            if (!this.ExistingRecord)
                throw new Exception("This record does not exist.");

            Hashtable parameterList = new Hashtable();
            parameterList.Add("@TicketId", this.TicketId);
            parameterList.Add("@UserId", modifiedBy);
            parameterList.Add("@SubjectValue", this.SubjectValue);
            parameterList.Add("@DescriptionValue", this.DescriptionValue);
            parameterList.Add("@Type", this.Type);
            parameterList.Add("@EstimatedHours", this.EstimatedHours);
            parameterList.Add("@OwnerId", this.OwnerId);
            parameterList.Add("@RequestedBy", this.RequestedBy);
            parameterList.Add("@PriorityLevelId", this.PriorityLevelId);
            parameterList.Add("@StatusId", this.StatusId);
            parameterList.Add("@DateAssigned", this.DateAssigned);
            parameterList.Add("@TargetDate", this.TargetDate);
            parameterList.Add("@DateCompleted", this.DateCompleted);
            parameterList.Add("@StateCode", this.StateCode);
            parameterList.Add("@PriorityOverride", this.PriorityOverride);
            parameterList.Add("@PriorityCompetition", this.PriorityCompetition);
            parameterList.Add("@PriorityCompliance", this.PriorityCompliance);
            parameterList.Add("@PriorityEfficiency", this.PriorityEfficiency);
            parameterList.Add("@PriorityFirmGoals", this.PriorityFirmGoals);
            parameterList.Add("@PriorityService", this.PriorityService);
            parameterList.Add("@PriorityTeamGoals", this.PriorityTeamGoals);
            Database.TicketTracker.ExecuteStoredProcedureNonQuery("[dbo].[usp_TicketUpdate]", parameterList);

            this.ExistingRecord = true;

            // Must execute last and in this order
            Workflow workflow = new Workflow(this);
            workflow.RunWorkflow();
            this.InstantiatedTicket = (Ticket)this.MemberwiseClone();
        }

        private void InsertDatabaseRecord(Guid createdBy)
        {
            if (this.ExistingRecord)
                throw new Exception("This record already exsits.");

            Hashtable parameterList = new Hashtable();
            parameterList.Add("@UserId", createdBy);
            parameterList.Add("@SubjectValue", this.SubjectValue);
            parameterList.Add("@DescriptionValue", this.DescriptionValue);
            parameterList.Add("@Type", this.Type);
            parameterList.Add("@EstimatedHours", this.EstimatedHours);
            parameterList.Add("@OwnerId", this.OwnerId);
            parameterList.Add("@RequestedBy", this.RequestedBy);
            parameterList.Add("@PriorityLevelId", this.PriorityLevelId);
            parameterList.Add("@StatusId", this.StatusId);
            parameterList.Add("@DateAssigned", this.DateAssigned);
            parameterList.Add("@TargetDate", this.TargetDate);
            parameterList.Add("@DateCompleted", this.DateCompleted);
            parameterList.Add("@StateCode", this.StateCode);
            parameterList.Add("@PriorityOverride", this.PriorityOverride);
            parameterList.Add("@PriorityCompetition", this.PriorityCompetition);
            parameterList.Add("@PriorityCompliance", this.PriorityCompliance);
            parameterList.Add("@PriorityEfficiency", this.PriorityEfficiency);
            parameterList.Add("@PriorityFirmGoals", this.PriorityFirmGoals);
            parameterList.Add("@PriorityService", this.PriorityService);
            parameterList.Add("@PriorityTeamGoals", this.PriorityTeamGoals);
            Database.TicketTracker.ExecuteStoredProcedureNonQuery("[dbo].[usp_TicketInsert]", parameterList);

            this.ExistingRecord = true;

            // Must execute last and in this order
            Workflow workflow = new Workflow(this);
            workflow.RunWorkflow();
            this.InstantiatedTicket = (Ticket)this.MemberwiseClone();
        }

        public void DeleteDatabaseRecord()
        {
            if (!this.ExistingRecord)
                throw new Exception("This record does not exist.");

            Hashtable parameterList = new Hashtable();
            parameterList.Add("@TicketId", this.TicketId);
            Database.TicketTracker.ExecuteStoredProcedureNonQuery("[dbo].[usp_TicketDelete]", parameterList);

            this.ExistingRecord = false;
        }

        public void SetDatabaseRecordAbandonded(Guid _userId)
        {
            this.StatusId = new Guid("C87BE859-C6F9-48F0-8E5F-743501182074");
            this.StateCode = 1;
            this.DateCompleted = null;

            this.UpdateDatabaseRecord(_userId);
        }

        public void SetDatabaseRecordCompleted(Guid _userId)
        {
            this.StatusId = new Guid("9704C561-B65B-4073-9939-202E9CCD6A87");
            this.StateCode = 1;
            this.DateCompleted = DateTime.Now;

            this.UpdateDatabaseRecord(_userId);
        }

        public void SetDatabaseRecordInProgress(Guid _userId)
        {
            this.StatusId = new Guid("06C16F0F-1ED1-4FEA-91A3-1B8E5DD44E6A");
            this.StateCode = 0;
            this.DateCompleted = null;

            this.UpdateDatabaseRecord(_userId);
        }

        /// <summary>
        /// Represents a <see cref="List"/> of <see cref="Task"/> instances that have been completed
        /// in the past week.
        /// </summary>
        /// <returns>Tasks completed in the past week.</returns>
        public List<Task> TasksCompletedInPastWeek()
        {
            List<Task> list = new List<Task>();

            foreach (Task task in Task.AssociatedTasks(this))
            {
                if (task.CompletedOn == null || ((DateTime)task.CompletedOn) <= DateTime.Now.AddDays(-7))
                {
                    continue;
                }

                list.Add(task);
            }

            return list;
        }

        /// <summary>
        /// Represents a <see cref="List"/> of <see cref="Task"/> instances that have been created
        /// in the past week.
        /// </summary>
        /// <returns>Tasks created in the past week.</returns>
        public List<Task> TasksCreatedInPastWeek()
        {
            List<Task> list = new List<Task>();

            foreach (Task task in Task.AssociatedTasks(this))
            {
                if (task.CreatedOn <= DateTime.Now.AddDays(-7))
                {
                    continue;
                }

                list.Add(task);
            }

            return list;
        }

        /// <summary>
        /// Represents a <see cref="List"/> of <see cref="TicketTime"/> instances that have been entered
        /// in the past week.
        /// </summary>
        /// <returns>TicketTimes created in the past week.</returns>
        public List<TicketTime> TicketTimesInPastWeek()
        {
            List<TicketTime> list = new List<TicketTime>();

            foreach (TicketTime _ticketTime in TicketTime.AssociatedTicketTimes(this))
            {
                if (_ticketTime.StartTime <= DateTime.Now.AddDays(-7))
                {
                    continue;
                }

                list.Add(_ticketTime);
            }

            return list;
        }

        /// <summary>
        /// Represents the total amount of time entered against the ticket.
        /// </summary>
        /// <returns>The total amount of time entered against the ticket.</returns>
        public TimeSpan Duration()
        {
            decimal durationMinutes = 0;

            foreach (TicketTime _ticketTime in TicketTime.AssociatedTicketTimes(this))
            {
                durationMinutes += _ticketTime.DurationMinutes;
            }

            TimeSpan timeSpan = TimeSpan.FromMinutes((double)durationMinutes);
            return timeSpan;
        }

        public static List<Ticket> InProgressTickets()
        {
            List<Ticket> _list = new List<Ticket>();

            foreach (DataRow _dataRow in GetInProgress().Rows)
            {
                Guid _ticketId = new Guid(_dataRow["TicketId"].ToString());
                Ticket _ticket = new Ticket(_ticketId);
                _list.Add(_ticket);
            }

            return _list;
        }

        public static List<Ticket> ActiveTickets()
        {
            List<Ticket> _list = new List<Ticket>();

            foreach (DataRow _dataRow in GetActive().Rows)
            {
                Guid _ticketId = new Guid(_dataRow["TicketId"].ToString());
                Ticket _ticket = new Ticket(_ticketId);
                _list.Add(_ticket);
            }

            return _list;
        }

        public static List<Ticket> InactiveTickets()
        {
            List<Ticket> _list = new List<Ticket>();

            foreach (DataRow _dataRow in GetInactive().Rows)
            {
                Guid _ticketId = new Guid(_dataRow["TicketId"].ToString());
                Ticket _ticket = new Ticket(_ticketId);
                _list.Add(_ticket);
            }

            return _list;
        }

        public bool CreatedInPastWeek()
        {
            if (this.CreatedOn >= DateTime.Now.AddDays(-7))
            {
                return true;
            }

            return false;
        }

        public bool HasReceivedWeeklyEmailInPastWeek()
        {
            bool result = false;

            List<WeeklyEmailSend> associatedWeeklyEmailSend = WeeklyEmailSend.AssociatedFromTicket(TicketId);

            if (associatedWeeklyEmailSend.Count == 0)
            {
                result = false;
            }
            else
            {
                foreach (WeeklyEmailSend weeklyEmailSend in WeeklyEmailSend.AssociatedFromTicket(TicketId))
                {
                    if (weeklyEmailSend.CreatedOn >= DateTime.Now.AddDays(-7))
                    {
                        result = true;
                    }
                }
            }

            return result;
        }

        public static DataTable GetActive()
        {
            // Execute stored procedure and return datatable result
            return Database.TicketTracker.ExecuteStoredProcedureQuery("[dbo].[usp_TicketGetActive]");
        }

        public static DataTable GetInProgress()
        {
            // Execute stored procedure and return datatable result
            return Database.TicketTracker.ExecuteStoredProcedureQuery("[dbo].[usp_TicketGetInProgress]");
        }

        public static DataTable GetInactive()
        {
            // Execute stored procedure and return datatable result
            return Database.TicketTracker.ExecuteStoredProcedureQuery("[dbo].[usp_TicketGetInactive]");
        }

        private static DataTable GetDetails(Guid _ticketId)
        {
            // Prepare parameter list for stored procedure
            Hashtable parameterList = new Hashtable();
            parameterList.Add("@TicketId", _ticketId);

            // Execute stored procedure and return datatable result
            return Database.TicketTracker.ExecuteStoredProcedureQuery("[dbo].[usp_TicketGetDetails]", parameterList);
        }
    }
}
