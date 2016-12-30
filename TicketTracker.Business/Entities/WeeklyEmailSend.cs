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
    public class WeeklyEmailSend : IBusinessEntity
    {
        public Guid WeeklyEmailSendId;
        public Guid TicketId;
        public Guid CreatedBy { get; private set; }
        public Guid ModifiedBy { get; private set; }
        public string Subject;
        public string BodyHtml;
        public string ToRecipients;
        public DateTime CreatedOn { get; private set; }
        public DateTime ModifiedOn { get; private set; }

        /// <summary>
        /// Indicates whether the instance exists as a record in the database.
        /// </summary>
        public bool ExistingRecord { get; private set; }

        /// <summary>
        /// Creates an instance of a new instance of a task.
        /// </summary>
        public WeeklyEmailSend()
        {
            ExistingRecord = false;

            WeeklyEmailSendId = Guid.NewGuid();
        }

        /// <summary>
        /// Creates an instance of an existing task in the database.
        /// </summary>
        /// <param name="weeklyEmailSendId">Used to get the task database record.</param>
        public WeeklyEmailSend(Guid weeklyEmailSendId)
        {
            DataTable dataTable = GetDetails(weeklyEmailSendId);
            DataRow dataRow = dataTable.Rows[0];

            WeeklyEmailSendId = weeklyEmailSendId;

            Guid createdBy;
            Guid modifiedBy;
            DateTime createdOn;
            DateTime modifiedOn;

            StringParser.Parse(dataRow["Subject"].ToString(), out Subject);
            StringParser.Parse(dataRow["BodyHtml"].ToString(), out BodyHtml);
            StringParser.Parse(dataRow["ToRecipients"].ToString(), out ToRecipients);
            StringParser.Parse(dataRow["CreatedBy"].ToString(), out createdBy);
            StringParser.Parse(dataRow["ModifiedBy"].ToString(), out modifiedBy);
            StringParser.Parse(dataRow["CreatedOn"].ToString(), out createdOn);
            StringParser.Parse(dataRow["ModifiedOn"].ToString(), out modifiedOn);

            CreatedBy = createdBy;
            ModifiedBy = modifiedBy;
            CreatedOn = createdOn;
            ModifiedOn = modifiedOn;

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
            {
                throw new Exception("This record does not exist.");
            }

            Hashtable parameterList = new Hashtable();
            parameterList.Add("@WeeklyEmailSendId", this.WeeklyEmailSendId);
            parameterList.Add("@TicketId", this.TicketId);
            parameterList.Add("@Subject", this.Subject);
            parameterList.Add("@BodyHtml", this.BodyHtml);
            parameterList.Add("@ToRecipients", this.ToRecipients);
            parameterList.Add("@ModifiedBy", modifiedBy);
            Database.TicketTracker.ExecuteStoredProcedureNonQuery("[dbo].[usp_WeeklyEmailSendUpdate]", parameterList);

            this.ExistingRecord = true;
        }

        private void InsertDatabaseRecord(Guid createdBy)
        {
            if (this.ExistingRecord)
            {
                throw new Exception("This record already exsits.");
            }

            Hashtable parameterList = new Hashtable();
            parameterList.Add("@WeeklyEmailSendId", this.WeeklyEmailSendId);
            parameterList.Add("@TicketId", this.TicketId);
            parameterList.Add("@Subject", this.Subject);
            parameterList.Add("@BodyHtml", this.BodyHtml);
            parameterList.Add("@ToRecipients", this.ToRecipients);
            parameterList.Add("@CreatedBy", createdBy);
            Database.TicketTracker.ExecuteStoredProcedureNonQuery("[dbo].[usp_WeeklyEmailSendInsert]", parameterList);

            this.ExistingRecord = true;
        }

        public void DeleteDatabaseRecord()
        {
            if (!this.ExistingRecord)
            {
                throw new Exception("This record does not exist.");
            }

            Hashtable parameterList = new Hashtable();
            parameterList.Add("@WeeklyEmailSendId", this.WeeklyEmailSendId);
            Database.TicketTracker.ExecuteStoredProcedureNonQuery("[dbo].[usp_WeeklyEmailSendDelete]", parameterList);

            this.ExistingRecord = false;
        }

        public static List<WeeklyEmailSend> AssociatedFromTicket(Guid ticketId)
        {
            List<WeeklyEmailSend> list = new List<WeeklyEmailSend>();

            DataTable dataTable = GetAssociatedFromTicket(ticketId);

            if (dataTable.Rows != null && dataTable.Rows.Count > 0)
            {
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Guid weeklyEmailSendId = new Guid(dataRow["WeeklyEmailSendId"].ToString());
                    WeeklyEmailSend weeklyEmailSend = new WeeklyEmailSend(weeklyEmailSendId);
                    list.Add(weeklyEmailSend);
                }
            }

            return list;
        }
        
        /// <summary>
        /// Gets the details of the given WeeklyEmailSendId.
        /// </summary>
        /// <param name="weeklyEmailSendId">Used to get the WeeklyEmailSend database record.</param>
        /// <returns>Returns a datatable with the columns specified in the stored procedure usp_WeeklyEmailSendGetDetails.</returns>
        private static DataTable GetDetails(Guid weeklyEmailSendId)
        {
            Hashtable parameterList = new Hashtable();
            parameterList.Add("@WeeklyEmailSendId", weeklyEmailSendId);
            return Database.TicketTracker.ExecuteStoredProcedureQuery("[dbo].[usp_WeeklyEmailSendGetDetails]", parameterList);
        }

        /// <summary>
        /// Gets the associated <see cref="WeeklyEmailSend"/> instances of the given TicketId.
        /// </summary>
        /// <param name="ticketId">Used to get the WeeklyEmailSend database records</param>
        /// <returns>Returns a datatable with the columns specified in the stored procedure usp_WeeklyEmailSendGetAssociatedFromTicket.</returns>
        private static DataTable GetAssociatedFromTicket(Guid ticketId)
        {
            Hashtable parameterList = new Hashtable();
            parameterList.Add("@TicketId", ticketId);
            return Database.TicketTracker.ExecuteStoredProcedureQuery("[dbo].[usp_WeeklyEmailSendGetAssociatedFromTicket]", parameterList);
        }
    }
}
