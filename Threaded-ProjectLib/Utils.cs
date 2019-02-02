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
using System.Windows.Forms;

namespace ThreadedProjectLib
{
    class Utils
    {
        /*
         * Error Log Recording functions -- Error Message will be logged into "error_log.txt"
         * param: errorMsg - Error Message.
         * 
         */
        public static string errorLogFilePath = "error_log.txt";
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

        public static void ErrorManager(Exception type, string tableName, string errorMethod="")
        {
            if (type.GetType().FullName == "System.Data.SqlClient.SqlException")
            {
                Utils.WriteErrorLog("Table: " + tableName + " Method: " + errorMethod + " Message :" + type.Message + " -> " + type.GetType().ToString());
                MessageBox.Show("Having trouble with the SQL, Please Contact your administrator");
            }
            else if (type.GetType().FullName == "System.Data.SqlClient.InvalidOperationException")
            {
                Utils.WriteErrorLog("Table: " + tableName + " Method: " + errorMethod + " Message :" + type.Message + " -> " + type.GetType().ToString());
                MessageBox.Show("Query isn't executing, Please Contact your administrator");

            }
            else {
                Utils.WriteErrorLog("Table: " + tableName + " Method: " + errorMethod + " Message :" + type.Message + " -> " + type.GetType().ToString());
                MessageBox.Show("Please Contact your administrator");

            }

        }
    }
    
}
