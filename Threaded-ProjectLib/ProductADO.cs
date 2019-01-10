using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadedProjectLib
{
    class ProductADO : BaseADO
    {
        // database connection variable
        private BaseADO baseADO = new BaseADO();
        
        private string tableName = "Products";

        /* Get List of Suppliers from database */
        public List<object> GetProducts()
        {
            //List<Supplier> result = new List<Supplier>();
            List<object> result = new List<object>();
            try
            {
                result = baseADO.SelectData(tableName);
            }
            catch (Exception e)
            {
                Utils.WriteErrorLog("ProductADO.GETProducts() - table name: " + tableName + ": " + e.Message + " - " + e.GetType().ToString());
            }

            return result;
        }

        /* Get Supplier Information by supplierId*/
        public Supplier GetProductName(int productId)
        {
            Supplier result = null;
            IDictionary<string, string> conditions = new Dictionary<string, string>();
            conditions.Add("supplierId", productId.ToString());

            try
            {
                List<object> list = SelectData(tableName, null, conditions);

                Console.Write(list);
                //foreach (Dictionary<string, string> element in list)
                //{
                //    result = new Supplier(Convert.ToInt32(element["supplierId"]),
                //                                     element["supName"]);

                //}
            }
            catch (Exception e)
            {
                //MessageBox.Show("Error: " + e.Message, e.GetType().ToString());
            }

            return result;
        }

        /* Update Supplier Information */
        public bool UpdateProduct(int productId, string productName)
        {
            bool result = true;

            IDictionary<string, string> values = new Dictionary<string, string>();
            values.Add("ProdName", productName);

            IDictionary<string, string> conditions = new Dictionary<string, string>();
            conditions.Add("ProductId", productId.ToString());

            try
            {
                result = baseADO.UpdateData(tableName, values, conditions);

            }
            catch (Exception e)
            {
                //MessageBox.Show("Error: " + e.Message, e.GetType().ToString());
            }

            return result;
        }

        /* Insert Supplier to database */
        public bool InsertSuppliers(Supplier supplier)
        {
            bool result = true;

            List<string> values = new List<string>();
            values.Add(supplier.SupName);

            try
            {
               /// result = baseADO.InsertData(tableName, values);

            }
            catch (Exception e)
            {
                //MessageBox.Show("Error: " + e.Message, e.GetType().ToString());
            }

            return result;

        }

        public void TestingConnection()
        {
            /// only for testing purposes remove once done
            SqlConnection connection;
            using (connection = GetDBConnection())
            {
                connection.Open();
                Console.WriteLine("ServerVersion: {0}", connection.ServerVersion);
                Console.WriteLine("State: {0}", connection.State);
            }

            if (connection != null)
            {
                Console.WriteLine(connection);
                Console.WriteLine();
                Console.WriteLine("State: {0}", connection.State);
            }

        }

        /* Delete Supplier by supplierId*/
        /*public bool DeleteSupplier(it supplierId)
        {
            
            return (result!=0);
        }*/


    }
}

