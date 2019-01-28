using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadedProjectLib
{
    /* Author: Quynh Nguyen (Queenie)
     * Date: Dec - 17 - 2018
     * Implement sql functions to work with Supplier.
     */
    public class SupplierDB : BaseDB
    {
        List<Supplier> AssocSuppliers = new List<Supplier>();
        SqlConnection conn = null;

        /* Get List of Suppliers from database */
        public List<Supplier> GetSuppliers()
        {
            List<Supplier> result = new List<Supplier>();
            string query = "SELECT * FROM Suppliers";
            try
            {
                conn = GetConnection();
                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Supplier supplier = new Supplier(Convert.ToInt32(reader[0]),
                                                    Convert.ToString(reader[1]));
                    result.Add(supplier);
                }
            }
            catch (Exception e)
            {
                Utils.WriteErrorLog("SupplierDB.GetSuppliers() - table name: " + 
                    Utils.supplierTableName + ": " + e.Message + " - " + e.GetType().ToString());
            }
            finally
            {
                //close connection
                conn.Close();
            }
            return result;
        }

        /* Get Supplier Information by supplierId*/
        public Supplier GetSupplier(int supplierId)
        {
            Supplier result = null;

            string query = "SELECT * FROM Suppliers WHERE SupplierId = @SupplierId ";
            try
            {
                conn = GetConnection();
                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("SupplierId", supplierId);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result = new Supplier(Convert.ToInt32(reader[0]),
                                          Convert.ToString(reader[1]));
                }
            }
            catch (Exception e)
            {
                Utils.WriteErrorLog("SupplierDB.GetSupplier() - table name: " + 
                    Utils.supplierTableName + ": " + e.Message + " - " + e.GetType().ToString());
            }
            finally
            {
                //close connection
                conn.Close();
            }
            return result;
        }

        /* Update Supplier Information */
        public bool UpdateSupplier(int supplierId, string supName)
        {
            int rows = 0;

            string query = "UPDATE Suppliers SET SupName = @SupName " +
                            "WHERE SupplierId = @SupplierId ";
            try
            {
                conn = GetConnection();
                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("SupplierId", supplierId);
                command.Parameters.AddWithValue("SupName", supName);
                rows = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Utils.WriteErrorLog("SupplierDB.UpdateSupplier() - table name: " + 
                Utils.supplierTableName + ": " + e.Message + " - " + e.GetType().ToString());
            }
            finally
            {
                //close connection
                conn.Close();
            }
            return (rows != 0);
        }

        public List<Supplier> getSupplierByProductId(int productID)
        {
            string query = "SELECT [ProductSupplierId], [Supplierid], [SupName] " +
            "FROM[TravelExperts].[dbo].[PRODUCT_SUPPLIER] Where Productid =" + productID;
            using (SqlConnection connection = GetConnection())
            {
                SqlCommand command = new SqlCommand( query, connection);
                //open the connection
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                try
                {
                    Supplier supp = new Supplier();
                    while (reader.Read())
                    {
                        AssocSuppliers.Add(new Supplier(Convert.ToInt32(reader[1]), Convert.ToString(reader[2]), Convert.ToInt32(reader[0])));
                    }
                }
                finally
                {
                    // Always call Close when done reading.
                    reader.Close();
                }

                return AssocSuppliers;
            }
        }
        /* Insert Supplier to database */
        public bool InsertSuppliers(Supplier supplier)
        {

            int result = 0;

            string query = "INSERT INTO Suppliers (SupName) VALUES (@SupName)";
            try
            {
                conn = GetConnection();
                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("SupName", supplier.SupName);
                result = command.ExecuteNonQuery();


            }
            catch (Exception e)
            {
                Utils.WriteErrorLog("SupplierDB.InsertSuppliers() - table name: " + 
                    Utils.supplierTableName + ": " + e.Message + " - " + e.GetType().ToString());
            }
            finally
            {
                //close connection
                conn.Close();
            }
            return (result != 0);

        }

        public bool DeleteSupplier(int supplierId)
        {
            int result = 0;

            string query = "DELETE Suppliers WHERE SupplierId = @SupplierId";
            try
            {
                conn = GetConnection();
                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);
                result = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Utils.WriteErrorLog("SupplierDB.DeleteSupplier() - table name: " +
                    Utils.supplierTableName + ": " + e.Message + " - " + e.GetType().ToString());
            }
            finally
            {
                //close connection
                conn.Close();
            }

            return (result != 0);
        }


    }
}
