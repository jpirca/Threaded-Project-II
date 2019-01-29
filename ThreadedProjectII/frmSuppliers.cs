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
            string message = "";
            string messageBoxTitle = "";

            DialogResult dialogResult = MessageBox.Show("Are you sure to create/update the supplier with Name - \"" + txtSupplierName.Text + "\"?", 
                "Create/ Update Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SupplierDB ado = new SupplierDB();

                try
                {
                    if (this.editedSupplier == null || editedSupplier.SupplierId == -1) // insert supplier
                    {
                        editedSupplier = new Supplier(-1, txtSupplierName.Text);
                        messageBoxTitle = "Adding Supplier";
                        if (ado.InsertSuppliers(editedSupplier))
                            message = "The supplier \"" + txtSupplierName.Text + "\" was created sussccefully";
                        else
                            message = "The supplier \"" + txtSupplierName.Text + "\" was not created sussccefully";
                    }
                    else //update supplier
                    {
                        editedSupplier.SupName = txtSupplierName.Text; // set new supplier name supplier object
                        messageBoxTitle = "Updating Supplier";
                        if (ado.UpdateSupplier(editedSupplier))
                            message = "The supplier \"" + txtSupplierName.Text + "\" was updated sussccefully";
                        else
                            message = "The supplier \"" + txtSupplierName.Text + "\" was not updated sussccefully";              
                    
                    }
                }
                catch (Exception ex)
                {
                    message = ex.Message;
                    messageBoxTitle = "Update Supplier Error";

                }

                if(!String.IsNullOrEmpty(message))
                    MessageBox.Show(message, messageBoxTitle);
            }

            this.Close();
            
            //form1.setSupplier(editedSupplier);
            //form1.Show();
            //form1.Activate();
            //this.Close();
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
