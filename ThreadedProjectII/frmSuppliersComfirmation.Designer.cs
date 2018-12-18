namespace ThreadedProjectII
{
    partial class frmSuppliersComfirmation
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
            this.label10 = new System.Windows.Forms.Label();
            this.btnCancelSup = new System.Windows.Forms.Button();
            this.btnAddSup = new System.Windows.Forms.Button();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBackSup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(354, 39);
            this.label10.TabIndex = 57;
            this.label10.Text = "Create New Supplier";
            // 
            // btnCancelSup
            // 
            this.btnCancelSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelSup.Location = new System.Drawing.Point(300, 188);
            this.btnCancelSup.Name = "btnCancelSup";
            this.btnCancelSup.Size = new System.Drawing.Size(75, 23);
            this.btnCancelSup.TabIndex = 56;
            this.btnCancelSup.Text = "&Cancel";
            this.btnCancelSup.UseVisualStyleBackColor = true;
            this.btnCancelSup.Click += new System.EventHandler(this.btnCancelSup_Click);
            // 
            // btnAddSup
            // 
            this.btnAddSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSup.Location = new System.Drawing.Point(122, 188);
            this.btnAddSup.Name = "btnAddSup";
            this.btnAddSup.Size = new System.Drawing.Size(75, 23);
            this.btnAddSup.TabIndex = 55;
            this.btnAddSup.Text = "&Add";
            this.btnAddSup.UseVisualStyleBackColor = true;
            this.btnAddSup.Click += new System.EventHandler(this.btnAddSup_Click);
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierName.Location = new System.Drawing.Point(112, 133);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.ReadOnly = true;
            this.txtSupplierName.Size = new System.Drawing.Size(263, 22);
            this.txtSupplierName.TabIndex = 54;
            this.txtSupplierName.Text = "Supplier AAA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 53;
            this.label1.Text = "Name:";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(16, 82);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(369, 48);
            this.lblTitle.TabIndex = 52;
            this.lblTitle.Text = "Please check all the information below a click \"Add\" to create a Supplier";
            // 
            // btnBackSup
            // 
            this.btnBackSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackSup.Location = new System.Drawing.Point(212, 188);
            this.btnBackSup.Name = "btnBackSup";
            this.btnBackSup.Size = new System.Drawing.Size(75, 23);
            this.btnBackSup.TabIndex = 58;
            this.btnBackSup.Text = "&Back";
            this.btnBackSup.UseVisualStyleBackColor = true;
            this.btnBackSup.Click += new System.EventHandler(this.btnBackSup_Click);
            // 
            // frmSuppliersComfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 228);
            this.Controls.Add(this.btnBackSup);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnCancelSup);
            this.Controls.Add(this.btnAddSup);
            this.Controls.Add(this.txtSupplierName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmSuppliersComfirmation";
            this.Text = "frmSuppliersComfirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCancelSup;
        private System.Windows.Forms.Button btnAddSup;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBackSup;
    }
}