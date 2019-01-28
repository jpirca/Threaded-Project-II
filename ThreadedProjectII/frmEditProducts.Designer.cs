namespace ThreadedProjectII
{
    partial class frmEditProducts
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
            this.btnCancelPkg = new System.Windows.Forms.Button();
            this.btnEditProducts = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmbSelectProduct = new System.Windows.Forms.ComboBox();
            this.lstAssocSupplier = new System.Windows.Forms.ListBox();
            this.lstAvailSuppliers = new System.Windows.Forms.ListBox();
            this.btnAddSupp = new System.Windows.Forms.Button();
            this.RemSupp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancelPkg
            // 
            this.btnCancelPkg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelPkg.Location = new System.Drawing.Point(357, 394);
            this.btnCancelPkg.Name = "btnCancelPkg";
            this.btnCancelPkg.Size = new System.Drawing.Size(75, 23);
            this.btnCancelPkg.TabIndex = 41;
            this.btnCancelPkg.Text = "&Cancel";
            this.btnCancelPkg.UseVisualStyleBackColor = true;
            this.btnCancelPkg.Click += new System.EventHandler(this.btnCancelPkg_Click);
            // 
            // btnEditProducts
            // 
            this.btnEditProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProducts.Location = new System.Drawing.Point(218, 394);
            this.btnEditProducts.Name = "btnEditProducts";
            this.btnEditProducts.Size = new System.Drawing.Size(75, 23);
            this.btnEditProducts.TabIndex = 40;
            this.btnEditProducts.Text = "&Edit";
            this.btnEditProducts.UseVisualStyleBackColor = true;
            this.btnEditProducts.Click += new System.EventHandler(this.btnEditProducts_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Available Suppliers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Suppliers Asociated with the Product";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(126, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(253, 42);
            this.label10.TabIndex = 35;
            this.label10.Text = "Edit Products";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(70, 84);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(339, 16);
            this.lblTitle.TabIndex = 34;
            this.lblTitle.Text = "Please select the product to edit and press button \"Edit\":";
            // 
            // cmbSelectProduct
            // 
            this.cmbSelectProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectProduct.FormattingEnabled = true;
            this.cmbSelectProduct.Location = new System.Drawing.Point(120, 114);
            this.cmbSelectProduct.Name = "cmbSelectProduct";
            this.cmbSelectProduct.Size = new System.Drawing.Size(236, 21);
            this.cmbSelectProduct.TabIndex = 42;
            this.cmbSelectProduct.SelectedIndexChanged += new System.EventHandler(this.cmbSelectProduct_SelectedIndexChanged);
            // 
            // lstAssocSupplier
            // 
            this.lstAssocSupplier.FormattingEnabled = true;
            this.lstAssocSupplier.Location = new System.Drawing.Point(73, 189);
            this.lstAssocSupplier.Name = "lstAssocSupplier";
            this.lstAssocSupplier.Size = new System.Drawing.Size(139, 186);
            this.lstAssocSupplier.TabIndex = 43;
            // 
            // lstAvailSuppliers
            // 
            this.lstAvailSuppliers.FormattingEnabled = true;
            this.lstAvailSuppliers.Location = new System.Drawing.Point(318, 189);
            this.lstAvailSuppliers.Name = "lstAvailSuppliers";
            this.lstAvailSuppliers.Size = new System.Drawing.Size(147, 186);
            this.lstAvailSuppliers.TabIndex = 44;
            // 
            // btnAddSupp
            // 
            this.btnAddSupp.Location = new System.Drawing.Point(228, 228);
            this.btnAddSupp.Name = "btnAddSupp";
            this.btnAddSupp.Size = new System.Drawing.Size(75, 23);
            this.btnAddSupp.TabIndex = 45;
            this.btnAddSupp.Text = "Add";
            this.btnAddSupp.UseVisualStyleBackColor = true;
            this.btnAddSupp.Click += new System.EventHandler(this.btnAddSupp_Click);
            // 
            // RemSupp
            // 
            this.RemSupp.Location = new System.Drawing.Point(228, 288);
            this.RemSupp.Name = "RemSupp";
            this.RemSupp.Size = new System.Drawing.Size(75, 23);
            this.RemSupp.TabIndex = 46;
            this.RemSupp.Text = "Remove";
            this.RemSupp.UseVisualStyleBackColor = true;
            this.RemSupp.Click += new System.EventHandler(this.RemSupp_Click);
            // 
            // frmEditProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 438);
            this.Controls.Add(this.RemSupp);
            this.Controls.Add(this.btnAddSupp);
            this.Controls.Add(this.lstAvailSuppliers);
            this.Controls.Add(this.lstAssocSupplier);
            this.Controls.Add(this.cmbSelectProduct);
            this.Controls.Add(this.btnCancelPkg);
            this.Controls.Add(this.btnEditProducts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmEditProducts";
            this.Text = "Edit Product";
            this.Load += new System.EventHandler(this.frmEditProducts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelPkg;
        private System.Windows.Forms.Button btnEditProducts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmbSelectProduct;
        private System.Windows.Forms.ListBox lstAssocSupplier;
        private System.Windows.Forms.ListBox lstAvailSuppliers;
        private System.Windows.Forms.Button btnAddSupp;
        private System.Windows.Forms.Button RemSupp;
    }
}