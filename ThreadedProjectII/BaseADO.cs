using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadedProjectII
{
    /* Author: Quynh Nguyen (Queenie)
     * Date: Dec - 17 - 2018
     * Implement base sql functions.
     */
    class BaseADO
    {
        // database connection variable
        public SqlConnection cnn;

        /* Get List of Suppliers from database */
        public List<IDictionary<string, string>> SelectData(string tableName, List<string> selectColNames = null, IDictionary<string, string> conditions = null)
        {
            List<IDictionary<string, string>> result = new List<IDictionary<string, string>>();
            string selectPhase = "SELECT ";
            string fromPhase = "FROM ";
            string wherePhase = "WHERE ";
            string query;
            try
            {
                // get connection
                GetDBConnection();

                // build sql query
                //select phase
                if(selectColNames == null)
                {
                    selectPhase += " *,";
                }
                else
                {
                    foreach (string colName in selectColNames)
                    {
                        selectPhase += colName + ", ";
                    }
                }
                

                // from phase
                if(String.IsNullOrEmpty(tableName))
                {
                    // return error code;
                }
                else
                {
                    fromPhase += tableName + " ";
                }

                // conditions phase
                if (conditions != null)
                {
                    foreach (string col in conditions.Keys.ToArray())
                    {
                        wherePhase += col + " = '" + conditions[col] + "', ";
                    }
                }
                else
                    wherePhase = "";

                // integrate query
                query = selectPhase.Remove(selectPhase.LastIndexOf(","), 1) +
                        fromPhase +
                        wherePhase.Remove(wherePhase.LastIndexOf(","), 1); 

                SqlCommand command = new SqlCommand(query, cnn); // prepare query statement
                SqlDataReader reader = command.ExecuteReader(); // execute query
                while (reader.Read()) // parse data if there is
                {
                    IDictionary<string, string> element = new Dictionary<string, string>();
                    for(int i = 0; i < reader.FieldCount; i++)
                    {
                        element.Add(reader.GetName(i), reader[i].ToString());
                    }
                   
                    result.Add(element);
                }
            }
            catch (Exception e)
            {
                //MessageBox.Show("Error: " + e.Message, e.GetType().ToString());
                //log error message
            }
            finally
            {
                //close connection
                CloseDBConnection();
            }
            return result;
        }

        /* Update Supplier Information */
        public bool UpdateData(string tableName, IDictionary<string, string> updateColVals, IDictionary<string, string> conditions)
        {

            string updatePhase = "UPDATE ";
            string setPhase = "SET ";
            string wherePhase = "WHERE ";
            string query;
            int rows = 0;

            try
            {
                // get connection
                GetDBConnection();

                // build sql query
                // update phase
                if (String.IsNullOrEmpty(tableName))
                {
                    return false; //error code
                }
                else
                {
                    updatePhase += tableName;

                }


                // set phase
                if (updateColVals == null || updateColVals.Count < 0)
                {
                    // return error code;
                }
                else
                {
                    foreach (string key in updateColVals.Keys)
                    {
                        setPhase += key + " = '" + updateColVals[key] + "', ";
                    }
                }

                // conditions phase
                if (conditions != null)
                {
                    foreach (string col in conditions.Keys)
                    {
                        wherePhase += col + " = '" + conditions[col] + "', ";
                    }
                }
                else
                    wherePhase = "";

                // integrate query
                query = updatePhase + " " +
                        setPhase.Remove(wherePhase.LastIndexOf(","), 1) +
                        wherePhase.Remove(wherePhase.LastIndexOf(","), 1);

                SqlCommand command = new SqlCommand(query, cnn); // prepare query statement
                rows = command.ExecuteNonQuery(); ; // execute query

            }
            catch (Exception e)
            {
                //MessageBox.Show("Error: " + e.Message, e.GetType().ToString());
                //log error message
            }
            finally
            {
                //close connection
                CloseDBConnection();
            }
            return (rows != 0);
        }

        /* Insert Supplier to database */
        public bool InsertData(string tableName, List<string> values)
        {
            string insertPhase = "INSERT INTO ";
            string valuePhase = "VALUES(";
            string query;
            int rows = 0;

            try
            {
                // get connection
                GetDBConnection();

                // build sql query
                // update phase
                if (String.IsNullOrEmpty(tableName))
                {
                    return false; //error code
                }
                else
                {
                    insertPhase += tableName;

                }


                // values phase
                if (values != null && values.Count > 0)
                {
                    foreach (string val in values)
                    {
                        valuePhase += "'" + val + "', ";
                    }
                }
                else
                    return false; //error code

                // integrate query
                query = insertPhase + " " +
                        valuePhase.Remove(valuePhase.LastIndexOf(","), 1) + ")";

                SqlCommand command = new SqlCommand(query, cnn); // prepare query statement
                rows = command.ExecuteNonQuery(); ; // execute query

            }
            catch (Exception e)
            {
                //MessageBox.Show("Error: " + e.Message, e.GetType().ToString());
                //log error message
            }
            finally
            {
                //close connection
                CloseDBConnection();
            }
            return (rows != 0);

        }

        /* Delete function will be implemented if there is a demand on deleting*/
        private bool DeleteData(string tableName, IDictionary<string, object> conditions)
        {
            int result = 0;

            string query = "";// "DELETE Suppliers WHERE supplierId = '" + supplierId + "'";
            try
            {
                GetDBConnection();

                SqlCommand command = new SqlCommand(query, cnn);
                result = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                //MessageBox.Show("Error: " + e.Message, e.GetType().ToString());
            }
            finally
            {
                //close connection
                CloseDBConnection();
            }
            return (result!=0);
        }

        // get database connection
        public SqlConnection GetDBConnection()
        {
            BDConfiguration dbConf =  Utils.GetDBConfiguration();

            string connetionString = @"Data Source=" + dbConf.ServerName + 
                                        ";Initial Catalog=travelexperts;" +
                                        "User ID=" + dbConf.UserName + ";Password=" + dbConf.Password;
            try
            {
                if (cnn == null) // initialize only when connection does not exist
                {
                    cnn = new SqlConnection(connetionString);
                    cnn.Open();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Connection Error: " + ex.Message, ex.GetType().ToString());
            }
            return cnn;
        }

        // close database connection
        public bool CloseDBConnection()
        {
            try
            {
                if (cnn != null)
                {
                    cnn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Connection Error: " + ex.Message, ex.GetType().ToString());
            }

            return false;
        }       
    }
}
