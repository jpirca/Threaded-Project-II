using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadedProjectII
{
    /* Author: Quynh Nguyen (Queenie)
     * Date: Dec - 17 - 2018
     * Implement sql functions to work with Supplier.
     */
    class SupplierADO
    {
        // database connection variable
        protected SqlConnection cnn;

        /* Get List of Suppliers from database */
        public List<Supplier> GetSuppliers()
        {
            List<Supplier> result = null;
            string query = "SELECT * FROM Suppliers";
            try
            {
                GetDBConnection();

                SqlCommand command = new SqlCommand(query, cnn);
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
                MessageBox.Show("Error: " + e.Message, e.GetType().ToString());
            }
            finally
            {
                //close connection
                CloseDBConnection();
            }
            return result;
        }

        /* Get Supplier Information by supplierId*/
        public Supplier GetSupplier(int supplierId)
        {
            Supplier result = null;

            string query = "SELECT * FROM Suppliers WHERE supplierId = '" + supplierId + "'";
            try
            {
                GetDBConnection();

                SqlCommand command = new SqlCommand(query, cnn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result = new Supplier(Convert.ToInt32(reader[0]),
                                          Convert.ToString(reader[1]));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, e.GetType().ToString());
            }
            finally
            {
                //close connection
                CloseDBConnection();
            }
            return result;
        }

        /* Update Supplier Information */
        public bool UpdateSupplier(int supplierId, string supName)
        {
            int rows = 0;

            string query = "UPDATE Suppliers SET supName ='" + supName + "' " +
                            "WHERE supplierId = '" + supplierId + "'";
            try
            {
                GetDBConnection();

                SqlCommand command = new SqlCommand(query, cnn);
                rows = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, e.GetType().ToString());
            }
            finally
            {
                //close connection
                CloseDBConnection();
            }
            return (rows!=0);
        }

        /* Insert Supplier to database */
        public bool InsertSuppliers(Supplier supplier)
        {
            int result = 0;

            string query = "INSERT INTO Suppliers (supName) VALUES (@supName)";
            try
            {
                GetDBConnection();
                SqlCommand command = new SqlCommand(query, cnn);
                command.Parameters.Add(supplier.SupName);
                result = command.ExecuteNonQuery();
              
               
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, e.GetType().ToString());
            }
            finally
            {
                //close connection
                CloseDBConnection();
            }
            return (result != 0);

        }

        /* Delete Supplier by supplierId*/
        public bool DeleteSupplier(int supplierId)
        {
            int result = 0;

            string query = "DELETE Suppliers WHERE supplierId = '" + supplierId + "'";
            try
            {
                GetDBConnection();

                SqlCommand command = new SqlCommand(query, cnn);
                result = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, e.GetType().ToString());
            }
            finally
            {
                //close connection
                CloseDBConnection();
            }
            return (result!=0);
        }

        private SqlConnection GetDBConnection()
        {
            string connetionString = @"Data Source=WIN-50GP30FGO75;Initial Catalog=travelexperts;" +
                                    "User ID=sa;Password=sa";
            try
            {
                cnn = new SqlConnection(connetionString);
                cnn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error: " + ex.Message, ex.GetType().ToString());
            }

            return cnn;
        }

        private bool CloseDBConnection()
        {
            try
            {
                if (cnn != null)
                {
                    cnn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error: " + ex.Message, ex.GetType().ToString());
            }

            return false;
        }
    }
}
