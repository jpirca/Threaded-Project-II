using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadedProjectLib
{
    public class ProductDB : BaseDB
    {

        List<Product> Products = new List<Product>();
        

        // Get all products
        public List<Product> getAllProducts()
        {
            string queryString =
                "SELECT Productid, ProdName FROM dbo.Products";
            using (SqlConnection connection = GetConnection())
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
                        Products.Add(new Product() { ProductId = Convert.ToInt32(reader[0]), ProductName = reader[1].ToString() });
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
        public void AddProduct(string ProductName)
        {
            Console.WriteLine(ProductName);
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
                    command.CommandText = @"Select(MAX(Productid) + 1) From Products;";
                    int maxPId = (int)command.ExecuteScalar();

                    command.CommandText =
                        "SET IDENTITY_INSERT dbo.Products ON;" +
                        "Insert into dbo.Products ( Productid, ProdName ) VALUES (@maxPid, @pname) " +
                        "SET IDENTITY_INSERT dbo.Products OFF;";
                    command.Prepare();

                    command.Parameters.AddWithValue("@pname", ProductName);
                    command.Parameters.AddWithValue("@maxPid", maxPId);
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

        public void UpdateProduct(
            int Prodid, List<Supplier> assocSuppliers, string ProductName)
        {
            //Console.WriteLine(ProductName);
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
                    command.CommandText += string.Format("UPDATE [dbo].[Products_Suppliers] " +
                                                  "SET [ProductId] = @prodid, [SupplierId] = @supid " +
                                                  "where [ProductSupplierId] = @prodSupid");

                    // Set connection, etc.
                    for (int i = 0; i < assocSuppliers.Count; i++)
                    {
                        command.Parameters.Clear();
                        Console.WriteLine(assocSuppliers[i].SuppProductId);
                        Console.WriteLine("UPdate since supplier has product supplier id");
                        Console.WriteLine(assocSuppliers[i].SupplierId);

                        command.Parameters.AddWithValue("@supid", assocSuppliers[i].SupplierId);
                        command.Parameters.AddWithValue("@prodid", Prodid);
                        command.Parameters.AddWithValue("@prodSupid", assocSuppliers[i].SuppProductId);
                        command.ExecuteNonQuery();
                    }

                    command.CommandText = "UPDATE [dbo].[Products] SET[Products].[ProdName] = @prodName WHERE ProductId = 1 ";
                    command.Parameters.AddWithValue("@prodName", ProductName);
                    command.ExecuteNonQuery();

                    // Attempt to commit the transaction.

                    transaction.Commit();
                    Console.WriteLine("Records are written to database.");
                }
                catch (Exception ex)
                {
                    //send this to logs
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
