using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace PensionConsultants.Data
{
    public class Access
    {
        public SqlConnection CurrentSqlConnection { get; private set; }

        public Hashtable Parameters { get; private set; }

        public static enum PciConnections
        {
            TicketTracker = "Data Source=PCIISP;Initial Catalog=TicketTracker;Integrated Security=True"
        }

        public Access(PciConnections _pciConnection)
        {
            CurrentSqlConnection = new SqlConnection(_pciConnection.ToString());
            Parameters = new Hashtable();
        }

        public bool ConnectionSuccessful()
        {
            using (CurrentSqlConnection)
            {
                try
                {
                    CurrentSqlConnection.Open();
                }
                catch
                {
                    return false;
                }
            }

            return true;
        }

        public DataTable ExecuteStoredProcedureQuery(string storedProcedureName)
        {
            DataTable dt = null;
            int counter = 0;

            SqlCommand objSqlCommand = new SqlCommand(storedProcedureName, CurrentSqlConnection);
            objSqlCommand.CommandType = CommandType.StoredProcedure;

            using (CurrentSqlConnection)
            {
                using (objSqlCommand)
                {
                    if (Parameters != null)
                    {
                        foreach (string _parameterName in Parameters.Keys)
                        {
                            if (Parameters[_parameterName] == null || String.IsNullOrWhiteSpace(Parameters[_parameterName].ToString()))
                            {
                                objSqlCommand.Parameters.AddWithValue(_parameterName, DBNull.Value);
                            }
                            else
                            {
                                objSqlCommand.Parameters.AddWithValue(_parameterName, Parameters[_parameterName]);
                            }

                            if (_parameterName.StartsWith("@OUT_"))
                            {
                                objSqlCommand.Parameters[counter].Direction = ParameterDirection.Output;
                            }
                            else
                            {
                                objSqlCommand.Parameters[counter].Direction = ParameterDirection.Input;
                            }

                            counter++;
                        }
                    }

                    try
                    {
                        CurrentSqlConnection.Open();
                        dt = new DataTable();
                        dt.Load(objSqlCommand.ExecuteReader());
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }

            return dt;
        }

        public Int32 ExecuteStoredProcedureNonQuery(string storedProcedureName)
        {
            Int32 rowsAffected = 0;
            int counter = 0;

            SqlCommand objSqlCommand = new SqlCommand(storedProcedureName, CurrentSqlConnection);
            objSqlCommand.CommandType = CommandType.StoredProcedure;

            using (CurrentSqlConnection)
            {
                using (objSqlCommand)
                {
                    if (Parameters != null)
                    {
                        foreach (string _parameterName in Parameters.Keys)
                        {
                            if (Parameters[_parameterName] == null || String.IsNullOrWhiteSpace(Parameters[_parameterName].ToString()))
                            {
                                objSqlCommand.Parameters.AddWithValue(_parameterName, DBNull.Value);
                            }
                            else
                            {
                                objSqlCommand.Parameters.AddWithValue(_parameterName, Parameters[_parameterName]);
                            }

                            if (_parameterName.StartsWith("@OUT_"))
                            {
                                objSqlCommand.Parameters[counter].Direction = ParameterDirection.Output;
                            }
                            else
                            {
                                objSqlCommand.Parameters[counter].Direction = ParameterDirection.Input;
                            }

                            counter++;
                        }
                    }

                    try
                    {
                        CurrentSqlConnection.Open();
                        rowsAffected = objSqlCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }

            return rowsAffected;
        }

        public DataTable ExecuteSqlQuery(string sqlCommand)
        {
            DataTable dt = null;
            int counter = 0;

            SqlCommand objSqlCommand = new SqlCommand(sqlCommand, CurrentSqlConnection);
            objSqlCommand.CommandType = CommandType.Text;

            using (CurrentSqlConnection)
            {
                using (objSqlCommand)
                {
                    if (Parameters != null)
                    {
                        foreach (string _parameterName in Parameters.Keys)
                        {
                            if (Parameters[_parameterName] == null || String.IsNullOrWhiteSpace(Parameters[_parameterName].ToString()))
                            {
                                objSqlCommand.Parameters.AddWithValue(_parameterName, DBNull.Value);
                            }
                            else
                            {
                                objSqlCommand.Parameters.AddWithValue(_parameterName, Parameters[_parameterName]);
                            }

                            if (_parameterName.StartsWith("@OUT_"))
                            {
                                objSqlCommand.Parameters[counter].Direction = ParameterDirection.Output;
                            }
                            else
                            {
                                objSqlCommand.Parameters[counter].Direction = ParameterDirection.Input;
                            }

                            counter++;
                        }
                    }

                    try
                    {
                        CurrentSqlConnection.Open();
                        dt = new DataTable();
                        dt.Load(objSqlCommand.ExecuteReader());
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }

            return dt;
        }

        public Int32 ExecuteSqlNonQuery(string _sqlCommand)
        {
            Int32 rowsAffected = 0;
            int counter = 0;

            SqlCommand objSqlCommand = new SqlCommand(_sqlCommand, CurrentSqlConnection);
            objSqlCommand.CommandType = CommandType.Text;

            using (CurrentSqlConnection)
            {
                using (objSqlCommand)
                {
                    if (Parameters != null)
                    {
                        foreach (string _parameterName in Parameters.Keys)
                        {
                            if (Parameters[_parameterName] == null || String.IsNullOrWhiteSpace(Parameters[_parameterName].ToString()))
                            {
                                objSqlCommand.Parameters.AddWithValue(_parameterName, DBNull.Value);
                            }
                            else
                            {
                                objSqlCommand.Parameters.AddWithValue(_parameterName, Parameters[_parameterName]);
                            }

                            if (_parameterName.StartsWith("@OUT_"))
                            {
                                objSqlCommand.Parameters[counter].Direction = ParameterDirection.Output;
                            }
                            else
                            {
                                objSqlCommand.Parameters[counter].Direction = ParameterDirection.Input;
                            }

                            counter++;
                        }
                    }

                    try
                    {
                        CurrentSqlConnection.Open();
                        rowsAffected = objSqlCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }

            return rowsAffected;
        }
    }
}
