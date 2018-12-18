using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadedProjectII
{
    public partial class frmProductsComfirmation : Form
    {
        public frmProductsComfirmation()
        {
            InitializeComponent();
        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The product \"Product Name\" was created sussccefully","Adding Product");
            this.Close();
        }

        private void btnBackProd_Click(object sender, EventArgs e)
        {
            this.Close();
            frmProducts form1 = new frmProducts();
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
    }
}
