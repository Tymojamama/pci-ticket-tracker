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
    public class TicketTime : IBusinessEntity
    {
        public Guid TicketTimeId { get; private set; }
        public Guid TicketId;
        public Guid CreatedBy { get; private set; }
        public Guid ModifiedBy;

        public string SubjectValue;
        public string DescriptionValue;

        public DateTime CreatedOn { get; private set; }
        public DateTime ModifiedOn;
        public DateTime StartTime;
        public DateTime EndTime;

        public decimal DurationMinutes;

        public int StateCode;

        public bool ExistingRecord { get; private set; }

        public TicketTime()
        {
            ExistingRecord = false;

            TicketTimeId = Guid.NewGuid();
        }

        public TicketTime(Guid _ticketTimeId)
        {
            ExistingRecord = true;

            DataTable _dataTable = GetDetails(_ticketTimeId);
            DataRow _dataRow = _dataTable.Rows[0];

            Guid _createdBy;
            DateTime _createdOn;

            TicketTimeId = _ticketTimeId;

            SubjectValue = _dataRow["SubjectValue"].ToString();
            DescriptionValue = _dataRow["DescriptionValue"].ToString();

            StringParser.Parse(_dataRow["TicketId"].ToString(), out TicketId);
            StringParser.Parse(_dataRow["CreatedBy"].ToString(), out _createdBy);
            StringParser.Parse(_dataRow["ModifiedBy"].ToString(), out ModifiedBy);
            StringParser.Parse(_dataRow["DurationMinutes"].ToString(), out DurationMinutes);
            StringParser.Parse(_dataRow["StartTime"].ToString(), out StartTime);
            StringParser.Parse(_dataRow["EndTime"].ToString(), out EndTime);
            StringParser.Parse(_dataRow["CreatedOn"].ToString(), out _createdOn);
            StringParser.Parse(_dataRow["ModifiedOn"].ToString(), out ModifiedOn);

            CreatedBy = _createdBy;
            CreatedOn = _createdOn;
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
            parameterList.Add("@TicketTimeId", this.TicketTimeId);
            parameterList.Add("@TicketId", this.TicketId);
            parameterList.Add("@UserId", modifiedBy);
            parameterList.Add("@SubjectValue", this.SubjectValue);
            parameterList.Add("@DescriptionValue", this.DescriptionValue);
            parameterList.Add("@StartTime", this.StartTime);
            parameterList.Add("@EndTime", this.EndTime);
            parameterList.Add("@DurationMinutes", this.DurationMinutes);
            Database.TicketTracker.ExecuteStoredProcedureNonQuery("[dbo].[usp_TicketTimeUpdate]", parameterList);

            this.ExistingRecord = true;
        }

        private void InsertDatabaseRecord(Guid createdBy)
        {
            if (this.ExistingRecord)
                throw new Exception("This record already exsits.");

            Hashtable parameterList = new Hashtable();
            parameterList.Add("@TicketId", this.TicketId);
            parameterList.Add("@UserId", createdBy);
            parameterList.Add("@SubjectValue", this.SubjectValue);
            parameterList.Add("@DescriptionValue", this.DescriptionValue);
            parameterList.Add("@StartTime", this.StartTime);
            parameterList.Add("@EndTime", this.EndTime);
            parameterList.Add("@DurationMinutes", this.DurationMinutes);
            Database.TicketTracker.ExecuteStoredProcedureNonQuery("[dbo].[usp_TicketTimeInsert]", parameterList);

            this.ExistingRecord = true;
        }

        public void DeleteDatabaseRecord()
        {
            if (!this.ExistingRecord)
                throw new Exception("This record does not exist.");

            Hashtable parameterList = new Hashtable();
            parameterList.Add("@TicketTimeId", this.TicketTimeId);
            Database.TicketTracker.ExecuteStoredProcedureNonQuery("[dbo].[usp_TicketTimeDelete]", parameterList);

            this.ExistingRecord = true;
        }

        public static List<TicketTime> AssociatedTicketTimes(Ticket _ticket)
        {
            List<TicketTime> _list = new List<TicketTime>();

            foreach (DataRow _dataRow in GetAssociatedFromTicket(_ticket).Rows)
            {
                Guid _ticketId = new Guid(_dataRow["TicketTimeId"].ToString());
                TicketTime _ticketTime = new TicketTime(_ticketId);
                _list.Add(_ticketTime);
            }

            return _list;
        }

        public static DataTable GetAssociatedFromTicket(Ticket _ticket)
        {
            // Prepare parameter list for stored procedure
            Hashtable parameterList = new Hashtable();
            parameterList.Add("@TicketId", _ticket.TicketId);

            // Execute stored procedure and return datatable result
            return Database.TicketTracker.ExecuteStoredProcedureQuery("[dbo].[usp_TicketTimeGetAssociatedFromTicket]", parameterList);
        }

        private static DataTable GetDetails(Guid _ticketTimeId)
        {
            // Prepare parameter list for stored procedure
            Hashtable parameterList = new Hashtable();
            parameterList.Add("@TicketTimeId", _ticketTimeId);

            // Execute stored procedure and return datatable result
            return Database.TicketTracker.ExecuteStoredProcedureQuery("[dbo].[usp_TicketTimeGetDetails]", parameterList);
        }
    }
}
