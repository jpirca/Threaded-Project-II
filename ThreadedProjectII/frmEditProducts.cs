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
    public partial class frmEditProducts : Form
    {
        ProductDB perProduct = new ProductDB();
        SupplierDB perSupplier = new SupplierDB();
        public static List<Supplier> sa = new List<Supplier>();
        public static int Prodid;
        public static string ProdName;
        public frmEditProducts()
        {
            InitializeComponent();
        }

        private void frmEditProducts_Load(object sender, EventArgs e)
        {
            //Get All Products 
            List<Product> listProducts =  perProduct.getAllProducts();
            //Add Products and disable list view
            foreach (Product a in listProducts)
                cmbSelectProduct.Items.Add(a);
        }

        private void cmbSelectProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Supplier> assocSupplier = new List<Supplier>();
            List<Supplier> allSuppliers = new List<Supplier>();
            
            lstAssocSupplier.Items.Clear();
            lstAvailSuppliers.Items.Clear();
            
            //After selection turn on
            assocSupplier = perSupplier.getSupplierByProductId(cmbSelectProduct.SelectedIndex + 1);
            allSuppliers = perSupplier.GetSuppliers();
            
            //get selected index for product
            foreach (Supplier s in assocSupplier)
            {
                lstAssocSupplier.Items.Add(new Supplier(s.SupplierId, s.SupName, s.SuppProductId));
            }


            
            var AvailAssocDiff = allSuppliers
                                .Where(allSup => !assocSupplier.Any(assocSup => assocSup.SupplierId == allSup.SupplierId)).ToList();

            allSuppliers.Except(assocSupplier).ToList();


            foreach (Supplier asup in AvailAssocDiff)
            {
                lstAvailSuppliers.Items.Add(new Supplier(asup.SupplierId, asup.SupName, asup.SuppProductId));
            }

            assocSupplier.Clear();
            allSuppliers.Clear();
        }

        private void btnAddSupp_Click(object sender, EventArgs e)
        {
            lstAssocSupplier.Enabled = false;

            if (lstAvailSuppliers.SelectedIndex == -1)
            {
                lstAssocSupplier.ClearSelected();
                MessageBox.Show("You can add from Avaialble Suppliers!");
            }
            else {
                lstAssocSupplier.Enabled = true;
                //Add item to the Assoc list
                Console.WriteLine(Convert.ToInt32(((Supplier)lstAvailSuppliers.SelectedItem).SuppProductId));
                lstAssocSupplier.Items.Add( new Supplier( Convert.ToInt32(((Supplier)lstAvailSuppliers.SelectedItem).SupplierId), 
                                                          lstAvailSuppliers.SelectedItem.ToString(), Convert.ToInt32(((Supplier)lstAvailSuppliers.SelectedItem).SuppProductId)));
                lstAvailSuppliers.Items.Remove(new Supplier(Convert.ToInt32(((Supplier)lstAvailSuppliers.SelectedItem).SupplierId),
                                                          lstAvailSuppliers.SelectedItem.ToString(), Convert.ToInt32(((Supplier)lstAvailSuppliers.SelectedItem).SuppProductId)));
                lstAvailSuppliers.Items.RemoveAt(lstAvailSuppliers.SelectedIndex);
            }
        }

        private void RemSupp_Click(object sender, EventArgs e)
        {

            lstAvailSuppliers.Enabled = false;

            if (lstAssocSupplier.SelectedIndex == -1)
                {
                    lstAvailSuppliers.ClearSelected();
                    MessageBox.Show("you can remove from Asoociated Suppliers!");
                }
            else
            {
                lstAvailSuppliers.Enabled = true;
                //Add item to the Assoc list
                lstAssocSupplier.Items.Remove(new Supplier(Convert.ToInt32(((Supplier)lstAssocSupplier.SelectedItem).SupplierId),
                                                              lstAssocSupplier.SelectedItem.ToString(), Convert.ToInt32(((Supplier)lstAssocSupplier.SelectedItem).SuppProductId)));


                lstAvailSuppliers.Items.Add(new Supplier(Convert.ToInt32(((Supplier)lstAssocSupplier.SelectedItem).SupplierId),
                                                              lstAssocSupplier.SelectedItem.ToString(), Convert.ToInt32(((Supplier)lstAssocSupplier.SelectedItem).SuppProductId)));
                lstAssocSupplier.Items.RemoveAt(lstAssocSupplier.SelectedIndex);
            }
        }

        private void btnEditProducts_Click(object sender, EventArgs e)
        {
            //give me selected Product id
            Prodid = Convert.ToInt32(((Product)cmbSelectProduct.SelectedItem).ProductId);
            ProdName = cmbSelectProduct.SelectedItem.ToString();

            //give me all associated suppliers for products
            
            foreach ( Supplier sap in lstAssocSupplier.Items)
            {
                sa.Add(new Supplier(sap.SupplierId, sap.SupName, sap.SuppProductId));
            }

            //send to form for update
            frmProductsComfirmation ProductsConfirm = new frmProductsComfirmation();
            ProductsConfirm.Show();
        }

        private void btnCancelPkg_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
