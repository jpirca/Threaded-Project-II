using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Configuration;

namespace ThreadedProjectLib
{
    class Utils
    {

        public static string errorLogFilePath = "error_log.txt";

        
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
    }
    
}
