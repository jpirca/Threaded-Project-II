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
    }
    
}
