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
    public partial class frmSuppliers : Form
    {
        public Supplier editedSupplier = null;
        
        public frmSuppliers()
        {
            InitializeComponent();
        }

        private void btnNextSup_Click(object sender, EventArgs e)
        {
            //this.Close();
            frmSuppliersComfirmation form1 = new frmSuppliersComfirmation();
            if (editedSupplier == null)
                editedSupplier = new Supplier(-1, txtSupplierName.Text);
            else
                editedSupplier.SupName = txtSupplierName.Text;
            form1.setSupplier(editedSupplier);
            form1.Show();
            form1.Activate();
            this.Close();
        }

        private void btnCancelSup_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to Cancel?", "Adding \"Supplier\"", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        public void setEditedSupplier(Supplier supplier)
        {
            this.editedSupplier = supplier;
        }

        private void frmSuppliers_Load(object sender, EventArgs e)
        {
            if(editedSupplier != null)
            {
                txtSupplierName.Text = editedSupplier.SupName;
            }
        }
    }
}
