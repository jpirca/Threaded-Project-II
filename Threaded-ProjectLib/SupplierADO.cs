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
    public class SupplierADO
    {
        // database connection variable
        private BaseADO baseADO = new BaseADO();
        private SqlConnection con = null;
        private string tableName = "Suppliers";

        /* Get List of Suppliers from database */
        public List<Object> GetSuppliers()
        {
            //List<Supplier> result = new List<Supplier>();
            List<Object> result = new List<Object>();
            try
            {
                // get connection
                //List<IDictionary<string, string>> list = baseADO.SelectData(tableName);

                //foreach(Dictionary<string, string> element in list)
                //{
                //    Supplier supplier = new Supplier(Convert.ToInt32(element["supplierId"]), 
                //                                     element["supName"]);
                //    result.Add(supplier);
                //}
                result = baseADO.SelectData(tableName);
            }
            catch (Exception e)
            {
                Utils.WriteErrorLog("SupplierADO.GetSuppliers() - table name: " + tableName + ": " + e.Message + " - " + e.GetType().ToString());
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
                List<Object> list = baseADO.SelectData(tableName, null, conditions);

                foreach (Object element in list)
                {
                    //result = new Supplier(Convert.ToInt32(element["supplierId"]),
                                                    // element["supName"]);
                    result = (Supplier)element;
                }
            }
            catch (Exception e)
            {
                Utils.WriteErrorLog("SupplierADO.GetSupplier() - table name: " + tableName + ": " + e.Message + " - " + e.GetType().ToString());
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
                result = baseADO.UpdateData(tableName, values, conditions);

            }
            catch (Exception e)
            {
                Utils.WriteErrorLog("SupplierADO.UpdateSupplier() - table name: " + tableName + ": " + e.Message + " - " + e.GetType().ToString());
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
                result = baseADO.InsertData(tableName, values);

            }
            catch (Exception e)
            {
                Utils.WriteErrorLog("SupplierADO.InsertSuppliers() - table name: " + tableName + ": " + e.Message + " - " + e.GetType().ToString());
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
