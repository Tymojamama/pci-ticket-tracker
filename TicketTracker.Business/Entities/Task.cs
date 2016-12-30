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
    public class Task : IBusinessEntity
    {
        public Guid TaskId;
        public Guid TicketId;
        public Guid StatusId;
        public Guid ModifiedBy;
        public Guid CreatedBy;
        public string SubjectValue;
        public string DescriptionValue;
        public DateTime ModifiedOn;
        public DateTime CreatedOn;
        public DateTime? DueOn;
        public DateTime? CompletedOn;
        public int StateCode;

        /// <summary>
        /// Indicates whether the instance exists as a record in the database.
        /// </summary>
        public bool ExistingRecord { get; private set; }

        /// <summary>
        /// Creates an instance of a new instance of a task.
        /// </summary>
        public Task()
        {
            ExistingRecord = false;

            TaskId = Guid.NewGuid();
            StatusId = new Guid("26F4101A-25C3-41E8-B528-BF65CF8410F4");
            StateCode = 0;
        }

        /// <summary>
        /// Creates an instance of an existing task in the database.
        /// </summary>
        /// <param name="taskId">Used to get the task database record.</param>
        public Task(Guid taskId)
        {
            DataTable _dataTable = GetDetails(taskId);
            DataRow _dataRow = _dataTable.Rows[0];

            TaskId = taskId;

            SubjectValue = _dataRow["SubjectValue"].ToString();
            DescriptionValue = _dataRow["DescriptionValue"].ToString();

            StringParser.Parse(_dataRow["TicketId"].ToString(), out TicketId);
            StringParser.Parse(_dataRow["StatusId"].ToString(), out StatusId);
            StringParser.Parse(_dataRow["ModifiedBy"].ToString(), out ModifiedBy);
            StringParser.Parse(_dataRow["CreatedBy"].ToString(), out CreatedBy);
            StringParser.Parse(_dataRow["ModifiedOn"].ToString(), out ModifiedOn);
            StringParser.Parse(_dataRow["CreatedOn"].ToString(), out CreatedOn);
            StringParser.Parse(_dataRow["DueOn"].ToString(), out DueOn);
            StringParser.Parse(_dataRow["CompletedOn"].ToString(), out CompletedOn);
            StringParser.Parse(_dataRow["StateCode"].ToString(), out StateCode);

            ExistingRecord = true;
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
            parameterList.Add("@TaskId", this.TaskId);
            parameterList.Add("@TicketId", this.TicketId);
            parameterList.Add("@StatusId", this.StatusId);
            parameterList.Add("@ModifiedBy", modifiedBy);
            parameterList.Add("@SubjectValue", this.SubjectValue);
            parameterList.Add("@DescriptionValue", this.DescriptionValue);
            parameterList.Add("@DueOn", this.DueOn);
            parameterList.Add("@CompletedOn", this.CompletedOn);
            parameterList.Add("@StateCode", this.StateCode);
            Database.TicketTracker.ExecuteStoredProcedureNonQuery("[dbo].[usp_TaskUpdate]", parameterList);

            this.ExistingRecord = true;
        }

        private void InsertDatabaseRecord(Guid createdBy)
        {
            if (this.ExistingRecord)
                throw new Exception("This record already exsits.");

            Hashtable parameterList = new Hashtable();
            parameterList.Add("@TicketId", this.TicketId);
            parameterList.Add("@StatusId", this.StatusId);
            parameterList.Add("@CreatedBy", createdBy);
            parameterList.Add("@SubjectValue", this.SubjectValue);
            parameterList.Add("@DescriptionValue", this.DescriptionValue);
            parameterList.Add("@DueOn", this.DueOn);
            parameterList.Add("@CompletedOn", this.CompletedOn);
            parameterList.Add("@StateCode", this.StateCode);
            Database.TicketTracker.ExecuteStoredProcedureNonQuery("[dbo].[usp_TaskInsert]", parameterList);

            this.ExistingRecord = true;
        }

        public void DeleteDatabaseRecord()
        {
            if (!this.ExistingRecord)
                throw new Exception("This record does not exist.");

            Hashtable parameterList = new Hashtable();
            parameterList.Add("@TaskId", this.TaskId);
            Database.TicketTracker.ExecuteStoredProcedureNonQuery("[dbo].[usp_TaskDelete]", parameterList);

            this.ExistingRecord = false;
        }
        
        /// <summary>
        /// Sets the task instance to complete.
        /// </summary>
        public void CompleteTask()
        {
            this.CompletedOn = DateTime.Now;
            this.StateCode = 1;
            this.StatusId = new Guid("C80F31C5-86A8-4C0C-87C6-037E77CE1ACC");
        }

        /// <summary>
        /// Represents a <see cref="List"/> of <see cref="Task"/> instances that are associated with the <see cref="Ticket"/> instance.
        /// </summary>
        /// <param name="ticket">Used to find all <see cref="Task"/> instances associated with the <see cref="Ticket"/> instance.</param>
        /// <returns>A list of tasks associated with the ticket.</returns>
        public static List<Task> AssociatedTasks(Ticket ticket)
        {
            List<Task> list = new List<Task>();

            foreach (DataRow dataRow in Task.GetAllAssociatedFromTicket(ticket.TicketId).Rows)
            {
                Guid taskId = new Guid(dataRow["TaskId"].ToString());
                Task task = new Task(taskId);
                list.Add(task);
            }

            return list;
        }

        /// <summary>
        /// Returns a DataTable of all associated, in progress tasks regarding a given TicketId.
        /// </summary>
        /// <param name="ticketId">Used to get all tasks with the TicketId.</param>
        /// <returns>Returns a datatable with the columns specified in the stored procedure usp_TaskGetAssociatedFromTicket.</returns>
        public static DataTable GetInProgressAssociatedFromTicket(Guid ticketId)
        {
            Hashtable parameterList = new Hashtable();
            parameterList.Add("@TicketId", ticketId);
            return Database.TicketTracker.ExecuteStoredProcedureQuery("[dbo].[usp_TaskGetInProgressAssociatedFromTicket]", parameterList);
        }

        /// <summary>
        /// Returns a DataTable of all associated, in progress tasks regarding a given TicketId.
        /// </summary>
        /// <param name="ticketId">Used to get all tasks with the TicketId.</param>
        /// <returns>Returns a datatable with the columns specified in the stored procedure usp_TaskGetAssociatedFromTicket.</returns>
        public static DataTable GetCompleteAssociatedFromTicket(Guid ticketId)
        {
            Hashtable parameterList = new Hashtable();
            parameterList.Add("@TicketId", ticketId);
            return Database.TicketTracker.ExecuteStoredProcedureQuery("[dbo].[usp_TaskGetCompleteAssociatedFromTicket]", parameterList);
        }

        /// <summary>
        /// Returns a DataTable of all associated tasks regarding a given TicketId.
        /// </summary>
        /// <param name="ticketId">Used to get all tasks with the TicketId.</param>
        /// <returns>Returns a datatable with the columns specified in the stored procedure usp_TaskGetAssociatedFromTicket.</returns>
        public static DataTable GetAllAssociatedFromTicket(Guid ticketId)
        {
            Hashtable parameterList = new Hashtable();
            parameterList.Add("@TicketId", ticketId);
            return Database.TicketTracker.ExecuteStoredProcedureQuery("[dbo].[usp_TaskGetAllAssociatedFromTicket]", parameterList);
        }

        /// <summary>
        /// Gets the details of the given TaskId.
        /// </summary>
        /// <param name="taskId">Used to get the task database record.</param>
        /// <returns>Returns a datatable with the columns specified in the stored procedure usp_TaskGetDetails.</returns>
        private static DataTable GetDetails(Guid taskId)
        {
            Hashtable parameterList = new Hashtable();
            parameterList.Add("@TaskId", taskId);
            return Database.TicketTracker.ExecuteStoredProcedureQuery("[dbo].[usp_TaskGetDetails]", parameterList);
        }
    }
}
