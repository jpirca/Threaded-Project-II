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
    public partial class frmEditSuppliers : Form
    {
        public frmEditSuppliers()
        {
            InitializeComponent();
            SupplierDB supADO = new SupplierDB();
            List<Supplier> suppliers = supADO.GetSuppliers();
            this.listBox1.Items.Clear();
            this.listBox1.DataSource = suppliers;
        }

        private void btnNextPkg_Click(object sender, EventArgs e)
        {
            this.Close();
            frmSuppliers form1 = new frmSuppliers();
            form1.setEditedSupplier((Supplier)this.listBox1.SelectedItem);
            form1.Show();
            form1.Activate();
        }

        private void btnCancelPkg_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Supplier selectedSupplier = (Supplier)this.listBox1.SelectedItem;
            if(selectedSupplier == null)
            {
                MessageBox.Show("Please select the supplier which you want to delete and try again.", "Not Select Supplier.");
            } else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure to delete the supplier with Name - \"" + selectedSupplier.SupName + "\"?",
                "Delete Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SupplierDB ado = new SupplierDB();
                    try
                    {
                        if (ado.DeleteSupplier(selectedSupplier.SupplierId)) // delete successfully
                        {
                            MessageBox.Show("The supplier \"" + selectedSupplier.SupName + "\" was deleted sussccefully",
                                "Deleting Supplier");
                        }
                        else
                        {
                            MessageBox.Show("The supplier \"" + selectedSupplier.SupName + "\" was not deleted sussccefully",
                                "Deleting Supplier");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Deleting Supplier Error");
                    }                   

                }

                this.Close();
            }            
        }
    }
}
