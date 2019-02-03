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
            string message = "";
            string messageBoxTitle = "";

            if (validaterClass.isProvided(txtAddProductName, "Product Name needs to be provided"))
            {
                string addProductName = txtAddProductName.Text;

                DialogResult dialogResult = MessageBox.Show("Are you sure to create the product with Name - \"" + txtAddProductName.Text + "\"?",
               "Create/ Update Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SupplierDB ado = new SupplierDB();

                    try
                    {
                        //Insert Product Name
                        perProduct.AddProduct(addProductName);
                        txtAddProductName.Text = "";
                    }
                    catch(Exception ex)
                    {
                        message = ex.Message;
                        messageBoxTitle = "Update Supplier Error";
                    }
                }
            }
            

        }

        private void btnCancelPkg_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
