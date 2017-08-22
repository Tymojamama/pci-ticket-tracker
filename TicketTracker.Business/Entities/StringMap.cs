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
    public class StringMap : IBusinessEntity
    {
        public Guid StringMapId { get; private set; }
        public Guid CreatedBy { get; private set; }
        public Guid ModifiedBy;

        public string StringValue;
        public string RegardingTable;
        public string RegardingColumn;

        public int? IntValue;
        public int? Ordinal;
        public int StateCode;

        public DateTime CreatedOn { get; private set; }
        public DateTime ModifiedOn;

        public bool ExistingRecord { get; private set; }

        public StringMap()
        {
            ExistingRecord = false;

            StringMapId = Guid.NewGuid();
        }

        public StringMap(Guid _stringMapId)
        {
            ExistingRecord = true;

            DataTable _dataTable = GetDetails(_stringMapId);
            DataRow _dataRow = _dataTable.Rows[0];

            Guid _createdBy;
            DateTime _createdOn;

            StringMapId = _stringMapId;

            StringParser.Parse(_dataRow["StringValue"].ToString(), out StringValue);
            StringParser.Parse(_dataRow["StringValue"].ToString(), out StringValue);
            StringParser.Parse(_dataRow["RegardingTable"].ToString(), out RegardingTable);
            StringParser.Parse(_dataRow["RegardingColumn"].ToString(), out RegardingColumn);
            StringParser.Parse(_dataRow["IntValue"].ToString(), out IntValue);
            StringParser.Parse(_dataRow["Ordinal"].ToString(), out Ordinal);
            StringParser.Parse(_dataRow["StateCode"].ToString(), out StateCode);
            StringParser.Parse(_dataRow["CreatedBy"].ToString(), out _createdBy);
            StringParser.Parse(_dataRow["ModifiedBy"].ToString(), out ModifiedBy);
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
            parameterList.Add("@StringMapId", this.StringMapId);
            parameterList.Add("@UserId", modifiedBy);
            parameterList.Add("@StringValue", this.StringValue);
            parameterList.Add("@IntValue", this.IntValue);
            parameterList.Add("@Ordinal", this.Ordinal);
            parameterList.Add("@RegardingTable", this.RegardingTable);
            parameterList.Add("@RegardingColumn", this.RegardingColumn);
            Database.TicketTracker.ExecuteStoredProcedureNonQuery("[dbo].[usp_StringMapUpdate]", parameterList);

            this.ExistingRecord = true;
        }

        private void InsertDatabaseRecord(Guid createdBy)
        {
            if (this.ExistingRecord)
                throw new Exception("This record already exsits.");

            Hashtable parameterList = new Hashtable();
            parameterList.Add("@UserId", createdBy);
            parameterList.Add("@StringValue", this.StringValue);
            parameterList.Add("@IntValue", this.IntValue);
            parameterList.Add("@RegardingTable", this.RegardingTable);
            parameterList.Add("@RegardingColumn", this.RegardingColumn);
            Database.TicketTracker.ExecuteStoredProcedureNonQuery("[dbo].[usp_StringMapInsert]", parameterList);

            this.ExistingRecord = true;
        }

        public void DeleteDatabaseRecord()
        {
            if (!this.ExistingRecord)
                throw new Exception("This record does not exist.");

            Hashtable parameterList = new Hashtable();
            parameterList.Add("@StringMapId", this.StringMapId);
            Database.TicketTracker.ExecuteStoredProcedureNonQuery("[dbo].[usp_StringMapDelete]", parameterList);

            this.ExistingRecord = false;
        }

        public static List<StringMap> AssociatedStringMaps(string _regardingTable, string _regardingColumn)
        {
            List<StringMap> _list = new List<StringMap>();

            foreach (DataRow _dataRow in GetAssociated(_regardingTable, _regardingColumn).Rows)
            {
                Guid _stringMapId = new Guid(_dataRow["StringMapId"].ToString());
                StringMap _stringMap = new StringMap(_stringMapId);
                _list.Add(_stringMap);
            }

            return _list;
        }

        public static DataTable GetDetails(Guid _stringMapId)
        {
            // Prepare parameter list for stored procedure
            Hashtable parameterList = new Hashtable();
            parameterList.Add("@StringMapId", _stringMapId);

            // Execute stored procedure and return datatable result
            return Database.TicketTracker.ExecuteStoredProcedureQuery("[dbo].[usp_StringMapGetDetails]", parameterList);
        }

        private static DataTable GetAssociated(string _regardingTable, string _regardingColumn)
        {
            // Prepare parameter list for stored procedure
            Hashtable parameterList = new Hashtable();
            parameterList.Add("@RegardingTable", _regardingTable);
            parameterList.Add("@RegardingColumn", _regardingColumn);

            // Execute stored procedure and return datatable result
            return Database.TicketTracker.ExecuteStoredProcedureQuery("[dbo].[usp_StringMapGetAssociated]", parameterList);
        }
    }
}
