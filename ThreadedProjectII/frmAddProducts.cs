using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThreadedProjectLib;

namespace ThreadedProjectII
{
    public partial class frmAddProducts : Form
    {
        ProductDB perProduct = new ProductDB();
        public frmAddProducts()
        {
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string addProductName = txtAddProductName.Text;

            //Insert Product Name
            perProduct.AddProduct(addProductName);
            MessageBox.Show("Product has been added");
            txtAddProductName.Text = "";

        }

        private void btnCancelPkg_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
