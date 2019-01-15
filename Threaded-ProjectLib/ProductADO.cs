using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadedProjectLib
{
    public class ProductADO : BaseADO
    {
        // database connection variable
        //private BaseADO baseADO = new BaseADO();
        //private SqlConnection con = null;

        private string tableName = "Products";
        //Get all the products
        //public List<Product> getAllProducts()
        //{
        //    string queryString =
        //        "SELECT ProductID, ProdName FROM dbo.Products";
        //    using (SqlConnection connection = base.GetConnection())
        //    {
        //        SqlCommand command = new SqlCommand(
        //            queryString, connection);
        //        //open the connection
        //        connection.Open();
        //        SqlDataReader reader = command.ExecuteReader();
        //        try
        //        {
        //            while (reader.Read())
        //            {
        //                Products.Add(new Product(Convert.ToInt32(reader[0]), reader[1].ToString()));
        //            }
        //        }
        //        finally
        //        {
        //            // Always call Close when done reading.
        //            reader.Close();
        //        }

        //        return Products;
        //    }
        //}

        ////Add a product with  prepare
        //public void AddProduct()
        //{
        //    using (SqlConnection connection = base.GetConnection())
        //    {
        //        connection.Open();
        //        SqlCommand command = connection.CreateCommand();
        //        SqlTransaction transaction;

        //        // Start a local transaction.
        //        transaction = connection.BeginTransaction("SimpleTransaction");

        //        // Must assign both transaction object and connection 
        //        // to Command object for a pending local transaction
        //        command.Connection = connection;
        //        command.Transaction = transaction;

        //        try
        //        {
        //            command.CommandText =
        //                "SET IDENTITY_INSERT dbo.Products ON;" +
        //                "Insert into Products ( ProdName ) VALUES (@pname)" +
        //                "SET IDENTITY_INSERT dbo.Products OFF;";
        //            command.Prepare();
        //            //command.Parameters.AddWithValue("@pid", "");
        //            command.Parameters.AddWithValue("@pname", "abc");
        //            command.ExecuteNonQuery();

        //            // Attempt to commit the transaction.
        //            transaction.Commit();
        //            Console.WriteLine("Records are written to database.");
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
        //            Console.WriteLine("  Message: {0}", ex.Message);

        //            // Attempt to roll back the transaction. 
        //            try
        //            {
        //                transaction.Rollback();
        //            }
        //            catch (Exception ex2)
        //            {
        //                // This catch block will handle any errors that may have occurred 
        //                // on the server that would cause the rollback to fail, such as 
        //                // a closed connection.
        //                Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
        //                Console.WriteLine("  Message: {0}", ex2.Message);
        //            }
        //        }
        //    }
        //}
        ///* Get List of Suppliers from database */
        public List<Product> GetProducts()
        {
            List<Product> result = new List<Product>();

            try
            {
                // get connection
               List<object> list = SelectData(tableName);

                foreach (Dictionary<string, string> element in list)
                {
                    Product products = new Product(
                        Convert.ToInt32(element["ProductID"]),
                                                    element["ProdName"]);
                   result.Add(products);
                }
            }
            catch (Exception e)
            {
                //We shouldnt use message box in the library change it to console or sent it to a logger file
                MessageBox.Show("Error: " + e.Message, e.GetType().ToString());
            }

            return result;
        }

        /* Get Supplier Information by supplierId*/
        public Supplier GetProductByID(int productId)
        {
            Supplier result = null;
            IDictionary<string, string> conditions = new Dictionary<string, string>();
            conditions.Add("ProductId", productId.ToString());

            try
            {
                List<object> list = SelectData(tableName, null, conditions);

                foreach (Dictionary<string, string> element in list)
                {
                    result = new Supplier(Convert.ToInt32(element["productId"]),
                                                     element["prodName"]);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, e.GetType().ToString());
            }

            return result;
        }

        /* Update Supplier Information */
        //public bool UpdateSupplier(int productId, string supName)
        //{
        //    bool result = true;

        //    IDictionary<string, string> values = new Dictionary<string, string>();
        //    values.Add("supName", supName);

        //    IDictionary<string, string> conditions = new Dictionary<string, string>();
        //    conditions.Add("supplierId", supplierId.ToString());

        //    try
        //    {
        //        result = UpdateData(tableName, values, conditions);

        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show("Error: " + e.Message, e.GetType().ToString());
        //    }

        //    return result;
        //}

        /* Insert Supplier to database */
        //public bool InsertProduct(Product product)
        //{
        //    bool result = true;

        //    List<string> values = new List<string>();
        //    values.Add(supplier.SupName);

        //    try
        //    {
        //      // result = baseADO.InsertData(tableName, values);

        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show("Error: " + e.Message, e.GetType().ToString());
        //    }

        //    return result;
        //}

        public void TestingConnection()
        {
            /// only for testing purposes remove once done
            SqlConnection connection;
            using (connection = base.GetConnection())
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
    }
}

