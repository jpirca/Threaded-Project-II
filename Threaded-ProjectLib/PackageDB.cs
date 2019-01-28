using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace ThreadedProjectLib
{
    public class PackageDB
    {
        /*Class to add packages to to packages table and perform select and other dml operations
         * on it.
         * Author: Muhammad islam
         * Created: Jan, 2019
         */
        //Make an object of Packages class to popoulate all data from packages table into its member variabls
        //Declare adatper,table and reader variable, ready to go for data population
        Packages pkgObj = new Packages();
        SqlDataAdapter adapter;
        public DataTable dt = new DataTable();
        public SqlDataReader reader;
        //function to get the connection, to TravelExperts database
        public string GetDBConnectionString()
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
            else
            {
                MessageBox.Show("Missing database configuration, please check those information in App.config");
            }

            return null;

        }

        //Add packages function getting data from form into arguments and sets the member variables
        public void addPackage(string pkgName, DateTime pkgStartDate, DateTime pkgEndDate, string pkgDesc
            , decimal pkgBasePrice, decimal pkgAgencyComm)
        {
            //pkgObj.packageId = pkgId;
            pkgObj.pkgName = pkgName;
            pkgObj.pkgStartDate = pkgStartDate;
            pkgObj.pkgEndDate = pkgEndDate;
            pkgObj.pkgDesc = pkgDesc;
            pkgObj.pkgBasePrice = pkgBasePrice;
            pkgObj.pkgAgencyComm = pkgAgencyComm;

            string dbConnect = GetDBConnectionString();
            // create sql connection object.  Be sure to put a valid connection string
            SqlConnection Con = new SqlConnection(dbConnect);
            // create command object with SQL query and link to connection object
            SqlCommand Cmd = new SqlCommand("INSERT INTO Packages " +
        "(PkgName, PkgStartDate, PkgEndDate,PkgDesc, PkgBasePrice,PkgAgencyCommission) " +
                "VALUES(@PackageName, @PackageStartDate,@PackageEndDate,@PackageDesc," +
                "@PackageBasePrice,@PackageAgencyCommission)", Con);

            //create your parameters
            Cmd.Parameters.AddWithValue("@PackageName", pkgObj.pkgName);
            Cmd.Parameters.AddWithValue("@PackageStartDate", pkgObj.pkgStartDate);
            Cmd.Parameters.AddWithValue("@PackageEndDate", pkgObj.pkgEndDate);
            Cmd.Parameters.AddWithValue("@PackageDesc", pkgObj.pkgDesc);
            Cmd.Parameters.AddWithValue("@PackageBasePrice", pkgObj.pkgBasePrice);
            Cmd.Parameters.AddWithValue("@PackageAgencyCommission", pkgObj.pkgAgencyComm);

            Con.Open();

            // execute the query and return number of rows affected, should be one
            int RowsAffected = Cmd.ExecuteNonQuery();

            // close connection when done
            Con.Close();
        }


        //function to populate datagrid
        public bool FillDataGrid()
        {
            bool dataFound = false;
            string dbConnect = GetDBConnectionString();
            // create sql connection object.  Be sure to put a valid connection string
            SqlConnection Con = new SqlConnection(dbConnect);
            // create command object with SQL query and link to connection object

            string query = "select * from packages";
            // string query = "select PkgName,PkgStartDate,PkgEndDate,PkgDesc,PkgBasePrice,PkgAgencyCommission" +
            //  " from packages";

            adapter = new SqlDataAdapter(query, Con);

            dt = new DataTable();
            adapter.Fill(dt);
            Con.Close();
            dataFound = true;
            return dataFound;

        }
        //Fetch suppliersid based on a join query to display data into product packages
        public bool FetchSuppliers(string prod, int packageID)
        {
            bool dataFound = false;
            // Newly added on Jan 28 2019
            string query = "select SupName from Suppliers s join Products_Suppliers ps " +
                "on s.SupplierId = ps.SupplierId join Products p on ps.ProductId = p.ProductId " +
                "where p.ProdName = @cmbProducts " +
                "and ps.SupplierId not in (select SupplierId from Products_Suppliers ps " +
                "join Packages_Products_Suppliers pps on ps.ProductSupplierId = pps.ProductSupplierId " +
                "where PackageId = @PackageId) " +
                "order by 1";
                
            //string query = "select SupName from products,products_suppliers,suppliers" +
            //    " where suppliers.SupName not in (select SupName from Products_Suppliers)" +
            //    " and suppliers.SupplierId=products_suppliers.SupplierId " +
            //    "and products.ProductId=products_suppliers.ProductId" +
            //    " and prodName= @cmbProducts";
            string dbConnect = GetDBConnectionString();
            // create sql connection object.  Be sure to put a valid connection string
            SqlConnection Con = new SqlConnection(dbConnect);
            Con.Open();
            // create command object with SQL query and link to connection object
            SqlCommand command;
            command = new SqlCommand(query, Con);
            //   command.Parameters.AddWithValue("@Name",criteria);
            command.Parameters.AddWithValue("@cmbProducts", prod);
            command.Parameters.AddWithValue("@PackageId", packageID);
            reader = command.ExecuteReader();
            dataFound = true;
            return dataFound;
        }
        //Fetch porducts from products class
        public bool fetchProducts()
        {
            bool dataFound = false;
            string dbConnect = GetDBConnectionString();

            // create sql connection object.  Be sure to put a valid connection string
            SqlConnection Con = new SqlConnection(dbConnect);
            Con.Open();
            // create command object with SQL query and link to connection object
            SqlCommand command;
            string query = "select prodName from products";
            command = new SqlCommand(query, Con);
            reader = command.ExecuteReader();
            if (reader != null)
            {
                dataFound = true;

                return dataFound;
            }
            Con.Close();
            return true;

        }

    }
}

