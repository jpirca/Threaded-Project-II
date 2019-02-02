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

        /*
         * Exception handling method
         *      tableName is used for logging exception at Data Access layer.
         */
        public static void ErrorManager(Exception exception, string tableName="", string errorMethod="")
        {
            string title = "TravelExperts Application Error";
            string errorMessage = "";
            //if (exception.GetType().FullName == "System.Data.SqlClient.SqlException")
            //{
            //    Utils.WriteErrorLog("Table: "+tableName+" Method: "+errorMethod+" Message :"+exception.Message + " -> " + exception.GetType().ToString());
            //    MessageBox.Show("Having trouble with the SQL, Please Contact your administrator");
            //}
            //else if (exception.GetType().FullName == "System.Data.SqlClient.InvalidOperationException")
            //{
            //    Utils.WriteErrorLog("Table: " + tableName + " Method: " + errorMethod + " Message :" + exception.Message + " -> " + exception.GetType().ToString());
            //    MessageBox.Show("Query isn't executing, Please Contact your administrator");

            //}
            //
            if (exception is SqlException) // Error at Data Access Layer
            {
                Utils.WriteErrorLog("Table: " + tableName + " Method: " + errorMethod
                            + " Message :" + exception.Message + " -> " + exception.GetType().ToString());
                errorMessage = "Having trouble with Database. Please Contact Administrator";
            }
            else if ((exception is InvalidOperationException || exception is ArgumentNullException)
                            && !String.IsNullOrEmpty(tableName)) // Error at Data Access Layer
            {
                Utils.WriteErrorLog("Table: " + tableName + " Method: " + errorMethod
                            + " Message :" + exception.Message + " -> " + exception.GetType().ToString());
                errorMessage = "Query isn't executing. Please Contact Administrator";

            }
            else //Error at Application Level
            {
                Utils.WriteErrorLog(" Method: " + errorMethod + " Message :" + exception.Message
                            + " -> " + exception.GetType().ToString());
                errorMessage = "Application's Error. Please Contact Administrator";
            }

            // show message box
            MessageBox.Show(errorMessage, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

}
