using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadedProjectLib
{
    /* Author: Quynh Nguyen (Queenie)
     * Date: Dec - 17 - 2018
     * Implement base sql functions.
     */
    public class BaseDB
    {

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(GetConnectionString());
        }

        static private string GetConnectionString()
        {
            // To avoid storing the connection string in your code, 
            // you can retrieve it from a configuration file, using the 
            // System.Configuration.ConfigurationManager.ConnectionStrings property 
            //Connects to the App config 

            ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;

            if (settings != null)
            {
                return ConfigurationManager.ConnectionStrings["travelexpertsLocalDB"].ConnectionString;
            }

            return null;

        }
        // database connection variable
        public SqlConnection cnn;

        /* Get List of Suppliers from database */
        public List<Object> SelectData(string tableName, List<string> selectColNames = null, IDictionary<string, string> conditions = null)
        {
            // variables declaration
            List<Object> result = new List<Object>();
            List<string> conditionKeys = new List<string>();

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
                if (selectColNames == null)
                {
                    selectPhase += " * ,";
                }
                else
                {
                    foreach (string colName in selectColNames)
                    {
                        selectPhase += colName + ", ";
                    }
                }


                // from phase
                if (String.IsNullOrEmpty(tableName))
                {
                    // return error code;
                }
                else
                {
                    fromPhase += tableName + " ";
                }

                // where phase
                if (conditions != null && conditions.Count > 0)
                {
                    conditionKeys = conditions.Keys.ToList();
                    wherePhase += Utils.BuildConditionStatement(conditionKeys);
                }
                else
                {
                    wherePhase = "";
                }

                // integrate query
                query = selectPhase.Remove(selectPhase.LastIndexOf(","), 1) +
                        fromPhase +
                        wherePhase;

                SqlCommand command = new SqlCommand(query, cnn); // prepare query statement

                // bind values to where statement
                if (conditions != null && conditions.Count > 0)
                {
                    Utils.PutValuesToDBCommand(conditions, command);
                }

                SqlDataReader reader = command.ExecuteReader(); // execute query
                while (reader.Read()) // parse data if there is
                {
                    IDictionary<string, string> element = new Dictionary<string, string>();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        element.Add(reader.GetName(i), reader[i].ToString());
                    }

                    // cast to object before adding to List
                    result.Add(Utils.CastDBElementToObject(element, tableName));
                }
            }
            catch (Exception e)
            {
                //log error message
                Utils.WriteErrorLog("BaseADO.SelectData() - table name: " + tableName + ": " + e.Message + " - " + e.GetType().ToString());


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
                if (updateColVals != null && updateColVals.Count > 0)
                {
                    setPhase += Utils.BuildConditionStatement(updateColVals.Keys.ToList());
                }
                else
                {
                    return false; //error code
                }

                // where phase
                if (conditions != null && conditions.Count > 0)
                {
                    wherePhase += Utils.BuildConditionStatement(conditions.Keys.ToList());
                }
                else
                {
                    wherePhase = "";
                }

                // integrate query
                query = updatePhase + " " +
                        setPhase +
                        wherePhase;

                SqlCommand command = new SqlCommand(query, cnn); // prepare query statement

                // bind values to set statement
                if (updateColVals != null && updateColVals.Count > 0)
                {
                    Utils.PutValuesToDBCommand(updateColVals, command);
                }

                // bind values to where statement
                if (conditions != null && conditions.Count > 0)
                {
                    Utils.PutValuesToDBCommand(conditions, command);
                }

                rows = command.ExecuteNonQuery(); ; // execute query

            }
            catch (Exception e)
            {
                Utils.WriteErrorLog("BaseADO.UpdateData() - table name: " + tableName + ": " + e.Message + " - " + e.GetType().ToString());
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
        public bool InsertData(string tableName, IDictionary<string, string> colValuePairs)
        {
            string insertPhase = "INSERT INTO ";
            string colsPhase = "(";
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
                if (colValuePairs != null && colValuePairs.Count > 0)
                {
                    foreach (string key in colValuePairs.Keys)
                    {
                        colsPhase += key + ", ";
                        valuePhase += "@" + key + ", ";
                    }
                }
                else
                    return false; //error code

                // integrate query
                query = insertPhase + " " +
                        colsPhase.Remove(colsPhase.LastIndexOf(","), 1) + ") " +
                        valuePhase.Remove(valuePhase.LastIndexOf(","), 1) + ")";

                SqlCommand command = new SqlCommand(query, cnn); // prepare query statement

                // bind values to db statement
                if (colValuePairs != null && colValuePairs.Count > 0)
                {
                    Utils.PutValuesToDBCommand(colValuePairs, command);
                }

                rows = command.ExecuteNonQuery(); ; // execute query

            }
            catch (Exception e)
            {
                Utils.WriteErrorLog("BaseADO.InsertData() - table name: " + tableName + ": " + e.Message + " - " + e.GetType().ToString());
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
        private bool DeleteData(string tableName, IDictionary<string, string> conditions)
        {
            int result = 0;

            string query = "DELETE FROM " + tableName + " WHERE " +
                            (conditions.Count > 0 ?
                                Utils.BuildConditionStatement(conditions.Keys.ToList()) :
                                "1=1");

            try
            {
                GetDBConnection();

                SqlCommand command = new SqlCommand(query, cnn);

                // bind values to db statement
                if (conditions != null && conditions.Count > 0)
                {
                    Utils.PutValuesToDBCommand(conditions, command);
                }

                result = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Utils.WriteErrorLog("BaseADO.DeleteData() - table name: " + tableName + ": " + e.Message + " - " + e.GetType().ToString());
            }
            finally
            {
                //close connection
                CloseDBConnection();
            }
            return (result != 0);
        }

        // get database connection
        public SqlConnection GetDBConnection()
        {
            //BDConfiguration dbConf =  Utils.GetDBConfiguration();

            //string connetionString = @"Data Source=" + dbConf.ServerName + 
            //                            ";Initial Catalog=travelexperts;" +
            //                            "User ID=" + dbConf.UserName + ";Password=" + dbConf.Password;

            string connetionString = Utils.GetDBConnectionString();

            try
            {
                if (cnn == null && connetionString != null) // initialize only when connection does not exist
                {
                    cnn = new SqlConnection(connetionString);
                    cnn.Open();
                }
            }
            catch (Exception e)
            {
                Utils.WriteErrorLog("BaseADO.GetDBConnection(): " + e.Message + " - " + e.GetType().ToString());
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
                    cnn = null;

                    return true;
                }
            }
            catch (Exception e)
            {
                Utils.WriteErrorLog("BaseADO.CloseDBConnection(): " + e.Message + " - " + e.GetType().ToString());
            }

            return false;
        }
    }
}
