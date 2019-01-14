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
    public partial class frmSuppliersComfirmation : Form
    {
        private Supplier supplier = null;
        public frmSuppliersComfirmation()
        {
            InitializeComponent();
        }

        private void btnAddSup_Click(object sender, EventArgs e)
        {
            SupplierADO ado = new SupplierADO();
            if(this.supplier == null || supplier.SupplierId == -1)
            {
                supplier = new Supplier(-1, txtSupplierName.Text);
                ado.InsertSuppliers(supplier);
            }
            else
            {
                ado.UpdateSupplier(supplier.SupplierId, supplier.SupName);
            }
            
           

            MessageBox.Show("The supplier \"" + txtSupplierName.Text + "\" was created sussccefully", "Adding Supplier");
            this.Close();
        }

        private void btnBackSup_Click(object sender, EventArgs e)
        {
            this.Close();
            frmSuppliers form1 = new frmSuppliers();
            form1.Activate();
            form1.Show();
        }

        private void btnCancelSup_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to Cancel?", "Adding \"Suppliers\"", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        public void setSupplier(Supplier supplier)
        {
            this.supplier = supplier;
        }

        private void frmSuppliersComfirmation_Load(object sender, EventArgs e)
        {
            if(this.supplier != null)
            {
                txtSupplierName.Text = supplier.SupName;
            }
        }
    }
}
