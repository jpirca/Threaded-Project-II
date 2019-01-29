﻿using System;
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
    public partial class frmProductsComfirmation : Form
    {
        ProductDB ourProducts = new ProductDB();
        public frmProductsComfirmation()
        {
            InitializeComponent();
        }

        

        private void btnBackProd_Click(object sender, EventArgs e)
        {
            this.Close();
            frmEditProducts form1 = new frmEditProducts();
            form1.Activate();
            form1.Show();
        }

        private void btnCancelProd_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to Cancel?", "Adding \"Products\"", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void frmProductsComfirmation_Load(object sender, EventArgs e)
        {
            txtConfProdName.Text = frmEditProducts.ProdName;

            foreach (Supplier assocSupplier in frmEditProducts.sa)
            {
                lstSuppliers.Items.Add(assocSupplier);
            }

           
        }

        private void btnUpdateProd_Click(object sender, EventArgs e)
        {

            ourProducts.UpdateProduct(frmEditProducts.sa, new Product(){ ProductId = frmEditProducts.Prodid, ProductName = frmEditProducts.ProdName });

            MessageBox.Show("Records updated");

        }
    }
}
