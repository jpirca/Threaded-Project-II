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
    public class SupplierDB
    {
        // database connection variable
        private BaseADO baseADO = new BaseADO();

        /* Get List of Suppliers from database */
        public List<Object> GetSuppliers()
        {
            List<Object> result = new List<Object>();
            try
            {
                result = baseADO.SelectData(Utils.supplierTableName);
            }
            catch (Exception e)
            {
                Utils.WriteErrorLog("SupplierADO.GetSuppliers() - table name: " + Utils.supplierTableName + ": " + e.Message + " - " + e.GetType().ToString());
            }

            return result;
        }

        /* Get Supplier Information by supplierId*/
        public Supplier GetSupplier(int supplierId)
        {
            Supplier result = null;
            IDictionary<string, string> conditions = new Dictionary<string, string>();
            conditions.Add("supplierId", supplierId.ToString());

            try
            {
                List<Object> list = baseADO.SelectData(Utils.supplierTableName, null, conditions);

                foreach (Object element in list)
                {
                    //result = new Supplier(Convert.ToInt32(element["supplierId"]),
                                                    // element["supName"]);
                    result = (Supplier)element;
                }
            }
            catch (Exception e)
            {
                Utils.WriteErrorLog("SupplierADO.GetSupplier() - table name: " + Utils.supplierTableName + ": " + e.Message + " - " + e.GetType().ToString());
            }

            return result;
        }

        /* Update Supplier Information */
        public bool UpdateSupplier(int supplierId, string supName)
        {
            bool result = true;

            IDictionary<string, string> values = new Dictionary<string, string>();
            values.Add("supName", supName);

            IDictionary<string, string> conditions = new Dictionary<string, string>();
            conditions.Add("supplierId", supplierId.ToString());

            try
            {
                result = baseADO.UpdateData(Utils.supplierTableName, values, conditions);

            }
            catch (Exception e)
            {
                Utils.WriteErrorLog("SupplierADO.UpdateSupplier() - table name: " + Utils.supplierTableName + ": " + e.Message + " - " + e.GetType().ToString());
            }

            return result;
        }

        /* Insert Supplier to database */
        public bool InsertSuppliers(Supplier supplier)
        {
            bool result = true;

            IDictionary<string, string> values = new Dictionary<string, string>();
            values.Add("SupName", supplier.SupName);

            try
            {
                result = baseADO.InsertData(Utils.supplierTableName, values);

            }
            catch (Exception e)
            {
                Utils.WriteErrorLog("SupplierADO.InsertSuppliers() - table name: " + Utils.supplierTableName + ": " + e.Message + " - " + e.GetType().ToString());
            }

            return result;

        }

        /* Delete Supplier by supplierId*/
        /*public bool DeleteSupplier(it supplierId)
        {
            
            return (result!=0);
        }*/

        
    }
}
