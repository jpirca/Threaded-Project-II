using System;
using System.Collections.Generic;
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
    class SupplierSQL
    {
        /* Get List of Suppliers from database */
        public List<Supplier> GetSuppliers()
        {
            List<Supplier> result = null;

            try
            {

                
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, e.GetType().ToString());
            }
            finally
            {
                //close connection
            }
            return result;
        }

        /* Get Supplier Information by supplierId*/
        public Supplier GetSupplier(int supplierId)
        {
            Supplier result = null;

            try
            {


            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, e.GetType().ToString());
            }
            finally
            {
                //close connection
            }
            return result;
        }

        /* Update Supplier Information */
        public bool UpdateSupplier(int supplierId, string supName)
        {
            bool result = false;

            try
            {


            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, e.GetType().ToString());
            }
            finally
            {
                //close connection
            }
            return result;
        }

        /* Delete Supplier by supplierId*/
        public bool DeleteSupplier(int supplierId)
        {
            bool result = false;

            try
            {


            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, e.GetType().ToString());
            }
            finally
            {
                //close connection
            }
            return result;
        }
    }
}
