namespace Treetest
{
    partial class frmPackages
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpPackage = new System.Windows.Forms.GroupBox();
            this.pkgGridView = new System.Windows.Forms.DataGridView();
            this.btnAddPackage = new System.Windows.Forms.Button();
            this.txtAgencyComm = new System.Windows.Forms.TextBox();
            this.txtPkgBasePrice = new System.Windows.Forms.TextBox();
            this.pkgEndigDate = new System.Windows.Forms.DateTimePicker();
            this.txtPkgDescription = new System.Windows.Forms.TextBox();
            this.pkgStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtPackageName = new System.Windows.Forms.TextBox();
            this.txtPackageId = new System.Windows.Forms.TextBox();
            this.lblPackageCommission = new System.Windows.Forms.Label();
            this.lblPkgBasePrice = new System.Windows.Forms.Label();
            this.lblPkgDescription = new System.Windows.Forms.Label();
            this.pkgEndDate = new System.Windows.Forms.Label();
            this.lblPkgStartDate = new System.Windows.Forms.Label();
            this.lblPkgName = new System.Windows.Forms.Label();
            this.lblPkgId = new System.Windows.Forms.Label();
            this.grpAddProducts = new System.Windows.Forms.GroupBox();
            this.pkgProductGrid = new System.Windows.Forms.DataGridView();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.lstSuppliers = new System.Windows.Forms.ListBox();
            this.lblSuppliers = new System.Windows.Forms.Label();
            this.lblProducts = new System.Windows.Forms.Label();
            this.cmbProducts = new System.Windows.Forms.ComboBox();
            this.grpPackage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pkgGridView)).BeginInit();
            this.grpAddProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pkgProductGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPackage
            // 
            this.grpPackage.Controls.Add(this.pkgGridView);
            this.grpPackage.Controls.Add(this.btnAddPackage);
            this.grpPackage.Controls.Add(this.txtAgencyComm);
            this.grpPackage.Controls.Add(this.txtPkgBasePrice);
            this.grpPackage.Controls.Add(this.pkgEndigDate);
            this.grpPackage.Controls.Add(this.txtPkgDescription);
            this.grpPackage.Controls.Add(this.pkgStartDate);
            this.grpPackage.Controls.Add(this.txtPackageName);
            this.grpPackage.Controls.Add(this.txtPackageId);
            this.grpPackage.Controls.Add(this.lblPackageCommission);
            this.grpPackage.Controls.Add(this.lblPkgBasePrice);
            this.grpPackage.Controls.Add(this.lblPkgDescription);
            this.grpPackage.Controls.Add(this.pkgEndDate);
            this.grpPackage.Controls.Add(this.lblPkgStartDate);
            this.grpPackage.Controls.Add(this.lblPkgName);
            this.grpPackage.Controls.Add(this.lblPkgId);
            this.grpPackage.Location = new System.Drawing.Point(12, 12);
            this.grpPackage.Name = "grpPackage";
            this.grpPackage.Size = new System.Drawing.Size(972, 289);
            this.grpPackage.TabIndex = 19;
            this.grpPackage.TabStop = false;
            this.grpPackage.Text = "Packages";
            // 
            // pkgGridView
            // 
            this.pkgGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pkgGridView.Location = new System.Drawing.Point(372, 19);
            this.pkgGridView.Name = "pkgGridView";
            this.pkgGridView.Size = new System.Drawing.Size(585, 174);
            this.pkgGridView.TabIndex = 34;
            // 
            // btnAddPackage
            // 
            this.btnAddPackage.Location = new System.Drawing.Point(145, 244);
            this.btnAddPackage.Name = "btnAddPackage";
            this.btnAddPackage.Size = new System.Drawing.Size(132, 40);
            this.btnAddPackage.TabIndex = 33;
            this.btnAddPackage.Text = "Add Package";
            this.btnAddPackage.UseVisualStyleBackColor = true;
            // 
            // txtAgencyComm
            // 
            this.txtAgencyComm.Location = new System.Drawing.Point(145, 218);
            this.txtAgencyComm.Name = "txtAgencyComm";
            this.txtAgencyComm.Size = new System.Drawing.Size(200, 20);
            this.txtAgencyComm.TabIndex = 32;
            // 
            // txtPkgBasePrice
            // 
            this.txtPkgBasePrice.Location = new System.Drawing.Point(145, 180);
            this.txtPkgBasePrice.Name = "txtPkgBasePrice";
            this.txtPkgBasePrice.Size = new System.Drawing.Size(200, 20);
            this.txtPkgBasePrice.TabIndex = 31;
            // 
            // pkgEndigDate
            // 
            this.pkgEndigDate.Location = new System.Drawing.Point(145, 116);
            this.pkgEndigDate.Name = "pkgEndigDate";
            this.pkgEndigDate.Size = new System.Drawing.Size(200, 20);
            this.pkgEndigDate.TabIndex = 30;
            // 
            // txtPkgDescription
            // 
            this.txtPkgDescription.Location = new System.Drawing.Point(145, 149);
            this.txtPkgDescription.Name = "txtPkgDescription";
            this.txtPkgDescription.Size = new System.Drawing.Size(200, 20);
            this.txtPkgDescription.TabIndex = 29;
            // 
            // pkgStartDate
            // 
            this.pkgStartDate.Location = new System.Drawing.Point(145, 84);
            this.pkgStartDate.Name = "pkgStartDate";
            this.pkgStartDate.Size = new System.Drawing.Size(200, 20);
            this.pkgStartDate.TabIndex = 28;
            // 
            // txtPackageName
            // 
            this.txtPackageName.Location = new System.Drawing.Point(145, 57);
            this.txtPackageName.Name = "txtPackageName";
            this.txtPackageName.Size = new System.Drawing.Size(200, 20);
            this.txtPackageName.TabIndex = 27;
            // 
            // txtPackageId
            // 
            this.txtPackageId.Location = new System.Drawing.Point(145, 26);
            this.txtPackageId.Name = "txtPackageId";
            this.txtPackageId.Size = new System.Drawing.Size(200, 20);
            this.txtPackageId.TabIndex = 26;
            // 
            // lblPackageCommission
            // 
            this.lblPackageCommission.AutoSize = true;
            this.lblPackageCommission.Location = new System.Drawing.Point(42, 221);
            this.lblPackageCommission.Name = "lblPackageCommission";
            this.lblPackageCommission.Size = new System.Drawing.Size(101, 13);
            this.lblPackageCommission.TabIndex = 25;
            this.lblPackageCommission.Text = "Agency Commission";
            // 
            // lblPkgBasePrice
            // 
            this.lblPkgBasePrice.AutoSize = true;
            this.lblPkgBasePrice.Location = new System.Drawing.Point(42, 180);
            this.lblPkgBasePrice.Name = "lblPkgBasePrice";
            this.lblPkgBasePrice.Size = new System.Drawing.Size(104, 13);
            this.lblPkgBasePrice.TabIndex = 24;
            this.lblPkgBasePrice.Text = "Package Base Price";
            // 
            // lblPkgDescription
            // 
            this.lblPkgDescription.AutoSize = true;
            this.lblPkgDescription.Location = new System.Drawing.Point(45, 156);
            this.lblPkgDescription.Name = "lblPkgDescription";
            this.lblPkgDescription.Size = new System.Drawing.Size(60, 13);
            this.lblPkgDescription.TabIndex = 23;
            this.lblPkgDescription.Text = "Description";
            // 
            // pkgEndDate
            // 
            this.pkgEndDate.AutoSize = true;
            this.pkgEndDate.Location = new System.Drawing.Point(45, 122);
            this.pkgEndDate.Name = "pkgEndDate";
            this.pkgEndDate.Size = new System.Drawing.Size(66, 13);
            this.pkgEndDate.TabIndex = 22;
            this.pkgEndDate.Text = "Ending Date";
            // 
            // lblPkgStartDate
            // 
            this.lblPkgStartDate.AutoSize = true;
            this.lblPkgStartDate.Location = new System.Drawing.Point(47, 83);
            this.lblPkgStartDate.Name = "lblPkgStartDate";
            this.lblPkgStartDate.Size = new System.Drawing.Size(69, 13);
            this.lblPkgStartDate.TabIndex = 21;
            this.lblPkgStartDate.Text = "Starting Date";
            // 
            // lblPkgName
            // 
            this.lblPkgName.AutoSize = true;
            this.lblPkgName.Location = new System.Drawing.Point(47, 57);
            this.lblPkgName.Name = "lblPkgName";
            this.lblPkgName.Size = new System.Drawing.Size(81, 13);
            this.lblPkgName.TabIndex = 20;
            this.lblPkgName.Text = "Package Name";
            // 
            // lblPkgId
            // 
            this.lblPkgId.AutoSize = true;
            this.lblPkgId.Location = new System.Drawing.Point(45, 26);
            this.lblPkgId.Name = "lblPkgId";
            this.lblPkgId.Size = new System.Drawing.Size(62, 13);
            this.lblPkgId.TabIndex = 19;
            this.lblPkgId.Text = "Package Id";
            // 
            // grpAddProducts
            // 
            this.grpAddProducts.Controls.Add(this.pkgProductGrid);
            this.grpAddProducts.Controls.Add(this.btnAddProduct);
            this.grpAddProducts.Controls.Add(this.lstSuppliers);
            this.grpAddProducts.Controls.Add(this.lblSuppliers);
            this.grpAddProducts.Controls.Add(this.lblProducts);
            this.grpAddProducts.Controls.Add(this.cmbProducts);
            this.grpAddProducts.Location = new System.Drawing.Point(12, 307);
            this.grpAddProducts.Name = "grpAddProducts";
            this.grpAddProducts.Size = new System.Drawing.Size(972, 262);
            this.grpAddProducts.TabIndex = 20;
            this.grpAddProducts.TabStop = false;
            this.grpAddProducts.Text = "Products";
            // 
            // pkgProductGrid
            // 
            this.pkgProductGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pkgProductGrid.Location = new System.Drawing.Point(372, 49);
            this.pkgProductGrid.Name = "pkgProductGrid";
            this.pkgProductGrid.Size = new System.Drawing.Size(384, 160);
            this.pkgProductGrid.TabIndex = 5;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(138, 217);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(207, 39);
            this.btnAddProduct.TabIndex = 4;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // lstSuppliers
            // 
            this.lstSuppliers.FormattingEnabled = true;
            this.lstSuppliers.Location = new System.Drawing.Point(138, 49);
            this.lstSuppliers.Name = "lstSuppliers";
            this.lstSuppliers.Size = new System.Drawing.Size(207, 160);
            this.lstSuppliers.TabIndex = 3;
            // 
            // lblSuppliers
            // 
            this.lblSuppliers.AutoSize = true;
            this.lblSuppliers.Location = new System.Drawing.Point(42, 52);
            this.lblSuppliers.Name = "lblSuppliers";
            this.lblSuppliers.Size = new System.Drawing.Size(50, 13);
            this.lblSuppliers.TabIndex = 2;
            this.lblSuppliers.Text = "Suppliers";
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Location = new System.Drawing.Point(42, 24);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(49, 13);
            this.lblProducts.TabIndex = 1;
            this.lblProducts.Text = "Products";
            // 
            // cmbProducts
            // 
            this.cmbProducts.FormattingEnabled = true;
            this.cmbProducts.Location = new System.Drawing.Point(138, 16);
            this.cmbProducts.Name = "cmbProducts";
            this.cmbProducts.Size = new System.Drawing.Size(207, 21);
            this.cmbProducts.TabIndex = 0;
            this.cmbProducts.SelectedIndexChanged += new System.EventHandler(this.cmbProducts_SelectedIndexChanged);
            // 
            // frmPackages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 599);
            this.Controls.Add(this.grpPackage);
            this.Controls.Add(this.grpAddProducts);
            this.Name = "frmPackages";
            this.Text = "Packages";
            this.Load += new System.EventHandler(this.frmPackages_Load);
            this.grpPackage.ResumeLayout(false);
            this.grpPackage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pkgGridView)).EndInit();
            this.grpAddProducts.ResumeLayout(false);
            this.grpAddProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pkgProductGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpPackage;
        private System.Windows.Forms.DataGridView pkgGridView;
        private System.Windows.Forms.Button btnAddPackage;
        private System.Windows.Forms.TextBox txtAgencyComm;
        private System.Windows.Forms.TextBox txtPkgBasePrice;
        private System.Windows.Forms.DateTimePicker pkgEndigDate;
        private System.Windows.Forms.TextBox txtPkgDescription;
        private System.Windows.Forms.DateTimePicker pkgStartDate;
        private System.Windows.Forms.TextBox txtPackageName;
        private System.Windows.Forms.TextBox txtPackageId;
        private System.Windows.Forms.Label lblPackageCommission;
        private System.Windows.Forms.Label lblPkgBasePrice;
        private System.Windows.Forms.Label lblPkgDescription;
        private System.Windows.Forms.Label pkgEndDate;
        private System.Windows.Forms.Label lblPkgStartDate;
        private System.Windows.Forms.Label lblPkgName;
        private System.Windows.Forms.Label lblPkgId;
        private System.Windows.Forms.GroupBox grpAddProducts;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.ComboBox cmbProducts;
        private System.Windows.Forms.ListBox lstSuppliers;
        private System.Windows.Forms.Label lblSuppliers;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.DataGridView pkgProductGrid;
    }
}