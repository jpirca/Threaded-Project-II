using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Configuration;
using System.Reflection;
using System.Data.SqlClient;

namespace ThreadedProjectLib
{
    class Utils
    {

        public static string errorLogFilePath = "error_log.txt";
        public static IDictionary<string, object> dbTableObjectClassMappings = new Dictionary<string, object>()
            {
                {"Suppliers", new Supplier()},
                {"Products", new Product()},
                {"Packages", "Package" }
            };
        // Load customer data from file.
        public static string GetDBConnectionString()
        {
            // To avoid storing the connection string in your code, 
            // you can retrieve it from a configuration file, using the 
            // System.Configuration.ConfigurationManager.ConnectionStrings property 
            //Connects to the App config 

            ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;

            if (settings != null)
            {
                foreach (ConnectionStringSettings cs in settings)
                {
                    return cs.ConnectionString;
                }
                //string connectionToString = @"Data Source=WIN-50GP30FGO75;Initial Catalog=Demodb;User ID=sa;Password=demol23";
            } else
            {
                WriteErrorLog("Missing database configuration, please check those information in App.config");
            }

            return null;
            
        }

        /*
         * Error Log Recording functions -- Error Message will be logged into "error_log.txt"
         * param: errorMsg - Error Message.
         * 
         */
        public static void WriteErrorLog(string errorMsg)
        {
            FileStream fs = null;
            StreamWriter sw = null;

            try
            {
                if (File.Exists(errorLogFilePath)) // append data when file exists
                {
                    //open the file for writing  and overwrite old content.
                    sw = File.AppendText(errorLogFilePath);
                }
                else //create a new file with name "error_log.txt"
                {
                    fs = new FileStream(errorLogFilePath, FileMode.Create, FileAccess.Write);
                    sw = new StreamWriter(fs);
                }

                // Write data
                sw.WriteLine(DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString() +  ": " + errorMsg);
            }
            finally
            {
                if (sw != null) sw.Close(); // also close fs
            }
        }

        /* Casting DB Element to relevent Object */
        public static Object CastDBElementToObject(IDictionary<string,string> element, string tableName)
        {
            Object instance = null;
            try
            {
                Object objectClassName = dbTableObjectClassMappings[tableName];
                Type objType = objectClassName.GetType();

                // Create an instance of the type
                instance = Activator.CreateInstance(objType);
                // Get MethodInfo, reflection class that is responsible for storing all relevant information about one method that type defines
                MethodInfo method = objType.GetMethod("CopyDataFromDBElement");

                // So we pass an instance to call it on and empty parameter list
                IDictionary<string,string>[] list = new IDictionary<string, string>[1];
                list[0] = element;

                method.Invoke(instance, list);
            }
            catch (Exception e)
            {
                Utils.WriteErrorLog("Utils.CastDBElementToObject(): " + e.Message + " - " + e.GetType().ToString());
            }

            return instance;
        }

        /* build condition statement for Database Query
         * variable "conditions" is a list of column Names
         * return string of conditions with @param to add compared value.
         */        
        public static string BuildConditionStatement(List<string> conditions)
        {
            string statement = "";
            
            foreach(string col in conditions)
            {
                statement += col + " = @" + col + ", ";
            }
            return statement.Remove(statement.LastIndexOf(","), 1);
        }

        /* Bind values to database command
         * Variables:
         *    conditions: key-value pairs
         *    command: sql command to bind value to
         * Return true | false
         */
        public static bool PutValuesToDBCommand(IDictionary<string, string> conditions, SqlCommand command)
        {
            try
            {
                List<string> conditionKeys = conditions.Keys.ToList();
                for (int i = 0; i < conditions.Count; i++)
                {
                    command.Parameters.AddWithValue("@" + conditionKeys[i], conditions[conditionKeys[i]]);
                }
            }
            catch (Exception e)
            {
                // error happen :(
                Utils.WriteErrorLog("Utils.PutValuesToDBCommand(): " + e.Message + " - " + e.GetType().ToString());
                return false; 
            }
            return true;
        }
    }
    
}
