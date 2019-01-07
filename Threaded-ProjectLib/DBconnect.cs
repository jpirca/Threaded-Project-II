using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace ThreadedProjectLib
{
     public abstract class DBconnect
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
                foreach (ConnectionStringSettings cs in settings)
                {
                    return cs.ConnectionString;
                }
                //string connectionToString = @"Data Source=WIN-50GP30FGO75;Initial Catalog=Demodb;User ID=sa;Password=demol23";
            }
            
            return null;
            
        }

    }
}


