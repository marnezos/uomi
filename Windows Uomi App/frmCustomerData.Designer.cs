namespace Windows_Uomi_App
{
    partial class frmCustomerData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerData));
            this.gbxCustomerType = new System.Windows.Forms.GroupBox();
            this.rdbWholesale = new System.Windows.Forms.RadioButton();
            this.rdbRetail = new System.Windows.Forms.RadioButton();
            this.gbxRetailData = new System.Windows.Forms.GroupBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.gbxWholesaleData = new System.Windows.Forms.GroupBox();
            this.txtVatNumber = new System.Windows.Forms.TextBox();
            this.lblVatNumber = new System.Windows.Forms.Label();
            this.txtBusinessName = new System.Windows.Forms.TextBox();
            this.lblBusinessName = new System.Windows.Forms.Label();
            this.gbxConctactData = new System.Windows.Forms.GroupBox();
            this.txtPhonenumber = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblPhonenumber = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbxCustomerType.SuspendLayout();
            this.gbxRetailData.SuspendLayout();
            this.gbxWholesaleData.SuspendLayout();
            this.gbxConctactData.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCustomerType
            // 
            this.gbxCustomerType.Controls.Add(this.rdbWholesale);
            this.gbxCustomerType.Controls.Add(this.rdbRetail);
            this.gbxCustomerType.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxCustomerType.Location = new System.Drawing.Point(12, 12);
            this.gbxCustomerType.Name = "gbxCustomerType";
            this.gbxCustomerType.Padding = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.gbxCustomerType.Size = new System.Drawing.Size(437, 49);
            this.gbxCustomerType.TabIndex = 1;
            this.gbxCustomerType.TabStop = false;
            this.gbxCustomerType.Text = "Customer Type";
            // 
            // rdbWholesale
            // 
            this.rdbWholesale.AutoSize = true;
            this.rdbWholesale.Dock = System.Windows.Forms.DockStyle.Left;
            this.rdbWholesale.Location = new System.Drawing.Point(120, 16);
            this.rdbWholesale.Name = "rdbWholesale";
            this.rdbWholesale.Size = new System.Drawing.Size(128, 30);
            this.rdbWholesale.TabIndex = 1;
            this.rdbWholesale.TabStop = true;
            this.rdbWholesale.Text = "-Wholesale Customer-";
            this.rdbWholesale.UseVisualStyleBackColor = true;
            // 
            // rdbRetail
            // 
            this.rdbRetail.AutoSize = true;
            this.rdbRetail.Dock = System.Windows.Forms.DockStyle.Left;
            this.rdbRetail.Location = new System.Drawing.Point(15, 16);
            this.rdbRetail.Name = "rdbRetail";
            this.rdbRetail.Size = new System.Drawing.Size(105, 30);
            this.rdbRetail.TabIndex = 0;
            this.rdbRetail.TabStop = true;
            this.rdbRetail.Text = "-Retail Customer-";
            this.rdbRetail.UseVisualStyleBackColor = true;
            this.rdbRetail.CheckedChanged += new System.EventHandler(this.CustomerTypeChanged);
            // 
            // gbxRetailData
            // 
            this.gbxRetailData.Controls.Add(this.txtLastName);
            this.gbxRetailData.Controls.Add(this.lblLastName);
            this.gbxRetailData.Controls.Add(this.txtFirstName);
            this.gbxRetailData.Controls.Add(this.lblFirstName);
            this.gbxRetailData.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxRetailData.Location = new System.Drawing.Point(12, 61);
            this.gbxRetailData.Name = "gbxRetailData";
            this.gbxRetailData.Size = new System.Drawing.Size(437, 77);
            this.gbxRetailData.TabIndex = 2;
            this.gbxRetailData.TabStop = false;
            this.gbxRetailData.Text = "-Retail Customer Data-";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(106, 47);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(316, 20);
            this.txtLastName.TabIndex = 4;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(12, 50);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(64, 13);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "-Last Name-";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(106, 21);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(316, 20);
            this.txtFirstName.TabIndex = 2;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(12, 25);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(63, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "-First Name-";
            // 
            // gbxWholesaleData
            // 
            this.gbxWholesaleData.Controls.Add(this.txtVatNumber);
            this.gbxWholesaleData.Controls.Add(this.lblVatNumber);
            this.gbxWholesaleData.Controls.Add(this.txtBusinessName);
            this.gbxWholesaleData.Controls.Add(this.lblBusinessName);
            this.gbxWholesaleData.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxWholesaleData.Location = new System.Drawing.Point(12, 138);
            this.gbxWholesaleData.Name = "gbxWholesaleData";
            this.gbxWholesaleData.Size = new System.Drawing.Size(437, 77);
            this.gbxWholesaleData.TabIndex = 3;
            this.gbxWholesaleData.TabStop = false;
            this.gbxWholesaleData.Text = "-Wholesale Customer Data-";
            this.gbxWholesaleData.Visible = false;
            // 
            // txtVatNumber
            // 
            this.txtVatNumber.Location = new System.Drawing.Point(106, 47);
            this.txtVatNumber.Name = "txtVatNumber";
            this.txtVatNumber.Size = new System.Drawing.Size(316, 20);
            this.txtVatNumber.TabIndex = 6;
            // 
            // lblVatNumber
            // 
            this.lblVatNumber.AutoSize = true;
            this.lblVatNumber.Location = new System.Drawing.Point(12, 50);
            this.lblVatNumber.Name = "lblVatNumber";
            this.lblVatNumber.Size = new System.Drawing.Size(74, 13);
            this.lblVatNumber.TabIndex = 5;
            this.lblVatNumber.Text = "-VAT Number-";
            // 
            // txtBusinessName
            // 
            this.txtBusinessName.Location = new System.Drawing.Point(106, 21);
            this.txtBusinessName.Name = "txtBusinessName";
            this.txtBusinessName.Size = new System.Drawing.Size(316, 20);
            this.txtBusinessName.TabIndex = 4;
            // 
            // lblBusinessName
            // 
            this.lblBusinessName.AutoSize = true;
            this.lblBusinessName.Location = new System.Drawing.Point(12, 25);
            this.lblBusinessName.Name = "lblBusinessName";
            this.lblBusinessName.Size = new System.Drawing.Size(86, 13);
            this.lblBusinessName.TabIndex = 3;
            this.lblBusinessName.Text = "-Business Name-";
            // 
            // gbxConctactData
            // 
            this.gbxConctactData.Controls.Add(this.txtPhonenumber);
            this.gbxConctactData.Controls.Add(this.txtAddress);
            this.gbxConctactData.Controls.Add(this.lblPhonenumber);
            this.gbxConctactData.Controls.Add(this.lblAddress);
            this.gbxConctactData.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxConctactData.Location = new System.Drawing.Point(12, 215);
            this.gbxConctactData.Name = "gbxConctactData";
            this.gbxConctactData.Size = new System.Drawing.Size(437, 77);
            this.gbxConctactData.TabIndex = 5;
            this.gbxConctactData.TabStop = false;
            this.gbxConctactData.Text = "-Contact Data-";
            // 
            // txtPhonenumber
            // 
            this.txtPhonenumber.Location = new System.Drawing.Point(106, 47);
            this.txtPhonenumber.Name = "txtPhonenumber";
            this.txtPhonenumber.Size = new System.Drawing.Size(316, 20);
            this.txtPhonenumber.TabIndex = 8;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(106, 21);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(316, 20);
            this.txtAddress.TabIndex = 7;
            // 
            // lblPhonenumber
            // 
            this.lblPhonenumber.AutoSize = true;
            this.lblPhonenumber.Location = new System.Drawing.Point(12, 50);
            this.lblPhonenumber.Name = "lblPhonenumber";
            this.lblPhonenumber.Size = new System.Drawing.Size(79, 13);
            this.lblPhonenumber.TabIndex = 1;
            this.lblPhonenumber.Text = "-Phonenumber-";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(12, 25);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(51, 13);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "-Address-";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Location = new System.Drawing.Point(12, 298);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 27);
            this.panel1.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.Location = new System.Drawing.Point(277, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 27);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "-Save-";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Location = new System.Drawing.Point(357, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 27);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "-Cancel-";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmCustomerData
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(461, 333);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbxConctactData);
            this.Controls.Add(this.gbxWholesaleData);
            this.Controls.Add(this.gbxRetailData);
            this.Controls.Add(this.gbxCustomerType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCustomerData";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "-Customer Data-";
            this.Load += new System.EventHandler(this.frmCustomerData_Load);
            this.gbxCustomerType.ResumeLayout(false);
            this.gbxCustomerType.PerformLayout();
            this.gbxRetailData.ResumeLayout(false);
            this.gbxRetailData.PerformLayout();
            this.gbxWholesaleData.ResumeLayout(false);
            this.gbxWholesaleData.PerformLayout();
            this.gbxConctactData.ResumeLayout(false);
            this.gbxConctactData.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxCustomerType;
        private System.Windows.Forms.GroupBox gbxRetailData;
        private System.Windows.Forms.RadioButton rdbWholesale;
        private System.Windows.Forms.RadioButton rdbRetail;
        private System.Windows.Forms.GroupBox gbxWholesaleData;
        private System.Windows.Forms.GroupBox gbxConctactData;
        private System.Windows.Forms.Label lblPhonenumber;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtVatNumber;
        private System.Windows.Forms.Label lblVatNumber;
        private System.Windows.Forms.TextBox txtBusinessName;
        private System.Windows.Forms.Label lblBusinessName;
        private System.Windows.Forms.TextBox txtPhonenumber;
        private System.Windows.Forms.TextBox txtAddress;
    }
}