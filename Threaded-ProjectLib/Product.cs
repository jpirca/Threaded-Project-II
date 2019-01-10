using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace ThreadedProjectLib
{
    public class Product 
    {
        /* Author: Jeremiah Lobo
         * Date: Jan - 5 - 2018
         * Implementing sql functions to work with Product.
         */
        private int _productId;
        private string _productName;

        List<Product> Products = new List<Product>();

        //constructor
        public Product() { }

        public Product(int productId = -1, string productName = "")
        {
            this._productId = productId;
            this._productName = productName;
        }
        //override to string constructor
        public override string ToString() => "" + this._productName;
        
        // Copy Data From Database Element
        public void CopyDataFromDBElement(IDictionary<string, string> element)
        {
            this._productId = Convert.ToInt32(element["ProductId"]);
            this._productName = element["ProdName"];
        }
    }
}
