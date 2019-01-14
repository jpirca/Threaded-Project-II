﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadedProjectLib
{
    /* Author: Quynh Nguyen (Queenie)
     * Date: Dec - 17 - 2018
     * Implement the object Supplier.
     */
     
    public class Supplier
    {
        private int supplierId;
        private string supName;

        /* Constructor: 
         * when supplierId = -1, Supplier object is initialized */
        public Supplier() { }

        public Supplier(int supplierId = -1, string supName = "")
        {
            this.supplierId = supplierId;
            this.supName = supName;
        }

        public int SupplierId
        {
            get; set;
        }

        public string SupName {
            set { supName = value; }
            get { return supName; }
        }

        public override string ToString()
        {
            return supplierId + ": " + supName;
        }

        // Copy Data From Database Element
        public void CopyDataFromDBElement(IDictionary<string, string> element)
        {
            this.supplierId = Convert.ToInt32(element["SupplierId"]);
            this.supName = element["SupName"];
        }
    }
}
