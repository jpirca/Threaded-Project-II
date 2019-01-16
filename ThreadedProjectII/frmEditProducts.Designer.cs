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
            this.lstboxProducts = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCancelPkg
            // 
            this.btnCancelPkg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelPkg.Location = new System.Drawing.Point(385, 444);
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
            this.btnEditProducts.Location = new System.Drawing.Point(290, 444);
            this.btnEditProducts.Name = "btnEditProducts";
            this.btnEditProducts.Size = new System.Drawing.Size(75, 23);
            this.btnEditProducts.TabIndex = 40;
            this.btnEditProducts.Text = "&Edit";
            this.btnEditProducts.UseVisualStyleBackColor = true;
            this.btnEditProducts.Click += new System.EventHandler(this.btnNextPkg_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(402, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Supplier";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Product";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(230, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(253, 42);
            this.label10.TabIndex = 35;
            this.label10.Text = "Edit Products";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(174, 115);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(339, 16);
            this.lblTitle.TabIndex = 34;
            this.lblTitle.Text = "Please select the product to edit and press button \"Edit\":";
            // 
            // lstboxProducts
            // 
            this.lstboxProducts.FormattingEnabled = true;
            this.lstboxProducts.Location = new System.Drawing.Point(170, 186);
            this.lstboxProducts.Name = "lstboxProducts";
            this.lstboxProducts.Size = new System.Drawing.Size(188, 225);
            this.lstboxProducts.TabIndex = 42;
            // 
            // frmEditProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 508);
            this.Controls.Add(this.lstboxProducts);
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
        private System.Windows.Forms.ListBox lstboxProducts;
    }
}