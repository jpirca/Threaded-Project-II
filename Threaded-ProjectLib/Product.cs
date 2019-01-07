using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace ThreadedProjectLib
{
    public class Product : DBconnect
    {
        /* Author: Jeremiah Lobo
         * Date: Jan - 5 - 2018
         * Implementing sql functions to work with Product.
         */
        private int _productId;
        private string _productName;

        List<Product> Products = new List<Product>();

        //constructor
        public Product(int productId, string productName)
        {
            this._productId = productId;
            this._productName = productName;
        }
        //override to string constructor
        public override string ToString() => "" + this._productName;

        //Get all the products
        public List<Product> getAllProducts()
        {
            string queryString =
                "SELECT ProductID, ProdName FROM dbo.Products";
            using (SqlConnection connection = base.GetConnection())
            {
                SqlCommand command = new SqlCommand(
                    queryString, connection);
                //open the connection
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        Products.Add(new Product(Convert.ToInt32(reader[0]), reader[1].ToString()));
                    }
                }
                finally
                {
                    // Always call Close when done reading.
                    reader.Close();
                }

                return Products;
            }
        }

        //Add a product with  prepare
        public void AddProduct()
        {
            using (SqlConnection connection = base.GetConnection())
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                SqlTransaction transaction;

                // Start a local transaction.
                transaction = connection.BeginTransaction("SimpleTransaction");

                // Must assign both transaction object and connection 
                // to Command object for a pending local transaction
                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    command.CommandText =
                        "SET IDENTITY_INSERT dbo.Products ON;" +
                        "Insert into Products ( ProdName ) VALUES (@pname)" +
                        "SET IDENTITY_INSERT dbo.Products OFF;";
                    command.Prepare();
                    //command.Parameters.AddWithValue("@pid", "");
                    command.Parameters.AddWithValue("@pname", "abc");
                    command.ExecuteNonQuery();

                    // Attempt to commit the transaction.
                    transaction.Commit();
                    Console.WriteLine("Records are written to database.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                    Console.WriteLine("  Message: {0}", ex.Message);

                    // Attempt to roll back the transaction. 
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        // This catch block will handle any errors that may have occurred 
                        // on the server that would cause the rollback to fail, such as 
                        // a closed connection.
                        Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                        Console.WriteLine("  Message: {0}", ex2.Message);
                    }
                }
            }
        }


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
