using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ThreadedProjectII
{
    class Utils
    {
        public static string configurationFilePath = "configurations.xml";
        public static string errorLogFilePath = "error_log.txt";

        public static BDConfiguration GetDBConfiguration()
        {
            BDConfiguration result = null;
            DBConfigurations configs = LoadDatabaseConfigurations();
            foreach(BDConfiguration conf in configs.Configurations)
            {
                if (conf.Enable == true)
                {
                    result = conf;
                    break;
                }
            }
            return result;
        }
        // Load customer data from file.
        public static DBConfigurations LoadDatabaseConfigurations()
        {
            DBConfigurations configs = new DBConfigurations();
            if (File.Exists(configurationFilePath)) // load data when file exists
            {
                XmlSerializer reader = new XmlSerializer(typeof(DBConfigurations));
                StreamReader file = new StreamReader(configurationFilePath);
                configs = (DBConfigurations)reader.Deserialize(file); // deserialize customers object from file data
                file.Close();
            }
            return configs;
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
                if (File.Exists(configurationFilePath)) // append data when file exists
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

    [Serializable]
    public class DBConfigurations
    {
        List<BDConfiguration> configurations = new List<BDConfiguration>();

        public DBConfigurations() { }

        public List<BDConfiguration> Configurations
        {
            get { return configurations; }
            set { configurations = value; }
        }
    }

    [Serializable]
    public class BDConfiguration
    {
        private string serverName = "";
        private string userName = "";
        private string password = "";
        private bool enable = false;

        public BDConfiguration() { }

        public string ServerName
        {
            get { return serverName; }
            set { serverName = value; }
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public bool Enable
        {
            get { return enable; }
            set { enable = value; }
        }
    }
}
