namespace Windows_Uomi_App
{
    partial class frmTransaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransaction));
            this.gbxDetails = new System.Windows.Forms.GroupBox();
            this.txtAmount = new Windows_Uomi_App.CurrencyTextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpTransaction = new System.Windows.Forms.DateTimePicker();
            this.gbxTransactionType = new System.Windows.Forms.GroupBox();
            this.lblTransactionType = new System.Windows.Forms.Label();
            this.gbxCustomer = new System.Windows.Forms.GroupBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblFormattedAmount = new System.Windows.Forms.Label();
            this.gbxDetails.SuspendLayout();
            this.gbxTransactionType.SuspendLayout();
            this.gbxCustomer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxDetails
            // 
            this.gbxDetails.Controls.Add(this.lblFormattedAmount);
            this.gbxDetails.Controls.Add(this.txtAmount);
            this.gbxDetails.Controls.Add(this.lblAmount);
            this.gbxDetails.Controls.Add(this.lblDate);
            this.gbxDetails.Controls.Add(this.dtpTransaction);
            this.gbxDetails.Location = new System.Drawing.Point(12, 144);
            this.gbxDetails.Name = "gbxDetails";
            this.gbxDetails.Size = new System.Drawing.Size(307, 133);
            this.gbxDetails.TabIndex = 1;
            this.gbxDetails.TabStop = false;
            this.gbxDetails.Text = "-Details-";
            // 
            // txtAmount
            // 
            this.txtAmount.DecimalPlaces = 2;
            this.txtAmount.DecimalsSeparator = '.';
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtAmount.Location = new System.Drawing.Point(75, 92);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PreFix = "$";
            this.txtAmount.Size = new System.Drawing.Size(100, 26);
            this.txtAmount.TabIndex = 0;
            this.txtAmount.ThousandsSeparator = ',';
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(16, 76);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(49, 13);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "-Amount-";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(16, 26);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 13);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "-Date-";
            // 
            // dtpTransaction
            // 
            this.dtpTransaction.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.dtpTransaction.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTransaction.Location = new System.Drawing.Point(16, 42);
            this.dtpTransaction.Name = "dtpTransaction";
            this.dtpTransaction.Size = new System.Drawing.Size(285, 20);
            this.dtpTransaction.TabIndex = 1;
            // 
            // gbxTransactionType
            // 
            this.gbxTransactionType.Controls.Add(this.lblTransactionType);
            this.gbxTransactionType.Location = new System.Drawing.Point(12, 12);
            this.gbxTransactionType.Name = "gbxTransactionType";
            this.gbxTransactionType.Size = new System.Drawing.Size(307, 60);
            this.gbxTransactionType.TabIndex = 2;
            this.gbxTransactionType.TabStop = false;
            this.gbxTransactionType.Text = "-Transaction Type-";
            // 
            // lblTransactionType
            // 
            this.lblTransactionType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTransactionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblTransactionType.Location = new System.Drawing.Point(3, 16);
            this.lblTransactionType.Name = "lblTransactionType";
            this.lblTransactionType.Size = new System.Drawing.Size(301, 41);
            this.lblTransactionType.TabIndex = 0;
            this.lblTransactionType.Text = "Credit";
            this.lblTransactionType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbxCustomer
            // 
            this.gbxCustomer.Controls.Add(this.lblCustomerName);
            this.gbxCustomer.Location = new System.Drawing.Point(12, 78);
            this.gbxCustomer.Name = "gbxCustomer";
            this.gbxCustomer.Size = new System.Drawing.Size(307, 60);
            this.gbxCustomer.TabIndex = 3;
            this.gbxCustomer.TabStop = false;
            this.gbxCustomer.Text = "-Customer-";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblCustomerName.Location = new System.Drawing.Point(3, 16);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(301, 41);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Customer Name";
            this.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Location = new System.Drawing.Point(12, 283);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 27);
            this.panel1.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.Location = new System.Drawing.Point(147, 0);
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
            this.btnCancel.Location = new System.Drawing.Point(227, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 27);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "-Cancel-";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblFormattedAmount
            // 
            this.lblFormattedAmount.AutoSize = true;
            this.lblFormattedAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblFormattedAmount.Location = new System.Drawing.Point(181, 95);
            this.lblFormattedAmount.Name = "lblFormattedAmount";
            this.lblFormattedAmount.Size = new System.Drawing.Size(17, 20);
            this.lblFormattedAmount.TabIndex = 4;
            this.lblFormattedAmount.Text = "  ";
            // 
            // frmTransaction
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(331, 318);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbxCustomer);
            this.Controls.Add(this.gbxTransactionType);
            this.Controls.Add(this.gbxDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "-Transaction-";
            this.Load += new System.EventHandler(this.frmTransaction_Load);
            this.gbxDetails.ResumeLayout(false);
            this.gbxDetails.PerformLayout();
            this.gbxTransactionType.ResumeLayout(false);
            this.gbxCustomer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxDetails;
        private System.Windows.Forms.DateTimePicker dtpTransaction;
        private System.Windows.Forms.GroupBox gbxTransactionType;
        private System.Windows.Forms.Label lblTransactionType;
        private System.Windows.Forms.GroupBox gbxCustomer;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private CurrencyTextBox txtAmount;
        private System.Windows.Forms.Label lblFormattedAmount;
    }
}