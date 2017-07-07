namespace Windows_Uomi_App
{
    partial class frmCustomerLedger
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerLedger));
            this.gbxCustomerData = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPhonenumber = new System.Windows.Forms.Label();
            this.lblPhonenumberValue = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblBalanceValue = new System.Windows.Forms.Label();
            this.lblAddressValue = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCustomerValue = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.gvwTransactions = new System.Windows.Forms.DataGridView();
            this.mnuLedgerPopup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuItemEditTransaction = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemDeleteTransaction = new System.Windows.Forms.ToolStripMenuItem();
            this.timestampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localizedAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxCustomerData.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvwTransactions)).BeginInit();
            this.mnuLedgerPopup.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCustomerData
            // 
            this.gbxCustomerData.Controls.Add(this.tableLayoutPanel1);
            this.gbxCustomerData.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxCustomerData.Location = new System.Drawing.Point(10, 10);
            this.gbxCustomerData.Name = "gbxCustomerData";
            this.gbxCustomerData.Padding = new System.Windows.Forms.Padding(12);
            this.gbxCustomerData.Size = new System.Drawing.Size(557, 110);
            this.gbxCustomerData.TabIndex = 0;
            this.gbxCustomerData.TabStop = false;
            this.gbxCustomerData.Text = "-Customer Data-";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.lblPhonenumber, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblPhonenumberValue, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblBalance, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblBalanceValue, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblAddressValue, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblAddress, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCustomerValue, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCustomer, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(533, 73);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblPhonenumber
            // 
            this.lblPhonenumber.AutoSize = true;
            this.lblPhonenumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPhonenumber.Location = new System.Drawing.Point(3, 48);
            this.lblPhonenumber.Name = "lblPhonenumber";
            this.lblPhonenumber.Size = new System.Drawing.Size(127, 25);
            this.lblPhonenumber.TabIndex = 7;
            this.lblPhonenumber.Text = "Phonenumber";
            this.lblPhonenumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPhonenumberValue
            // 
            this.lblPhonenumberValue.AutoSize = true;
            this.lblPhonenumberValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPhonenumberValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblPhonenumberValue.Location = new System.Drawing.Point(136, 48);
            this.lblPhonenumberValue.Name = "lblPhonenumberValue";
            this.lblPhonenumberValue.Size = new System.Drawing.Size(127, 25);
            this.lblPhonenumberValue.TabIndex = 6;
            this.lblPhonenumberValue.Text = "Phonenumber";
            this.lblPhonenumberValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBalance.Location = new System.Drawing.Point(269, 48);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(127, 25);
            this.lblBalance.TabIndex = 5;
            this.lblBalance.Text = "Balance";
            this.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBalanceValue
            // 
            this.lblBalanceValue.AutoSize = true;
            this.lblBalanceValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBalanceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblBalanceValue.Location = new System.Drawing.Point(402, 48);
            this.lblBalanceValue.Name = "lblBalanceValue";
            this.lblBalanceValue.Size = new System.Drawing.Size(128, 25);
            this.lblBalanceValue.TabIndex = 4;
            this.lblBalanceValue.Text = "Balance";
            this.lblBalanceValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAddressValue
            // 
            this.lblAddressValue.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblAddressValue, 3);
            this.lblAddressValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAddressValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblAddressValue.Location = new System.Drawing.Point(136, 24);
            this.lblAddressValue.Name = "lblAddressValue";
            this.lblAddressValue.Size = new System.Drawing.Size(394, 24);
            this.lblAddressValue.TabIndex = 3;
            this.lblAddressValue.Text = "Customer Address";
            this.lblAddressValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAddress.Location = new System.Drawing.Point(3, 24);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(127, 24);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Address";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustomerValue
            // 
            this.lblCustomerValue.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblCustomerValue, 3);
            this.lblCustomerValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCustomerValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblCustomerValue.Location = new System.Drawing.Point(136, 0);
            this.lblCustomerValue.Name = "lblCustomerValue";
            this.lblCustomerValue.Size = new System.Drawing.Size(394, 24);
            this.lblCustomerValue.TabIndex = 1;
            this.lblCustomerValue.Text = "Customer Name";
            this.lblCustomerValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCustomer.Location = new System.Drawing.Point(3, 0);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(127, 24);
            this.lblCustomer.TabIndex = 0;
            this.lblCustomer.Text = "Customer";
            this.lblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // transactionBindingSource
            // 
            this.transactionBindingSource.AllowNew = false;
            this.transactionBindingSource.DataSource = typeof(Windows_Uomi_App.Data.Transaction);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(10, 426);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel1.Size = new System.Drawing.Size(557, 37);
            this.panel1.TabIndex = 7;
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Location = new System.Drawing.Point(477, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 27);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "-Close-";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gvwTransactions
            // 
            this.gvwTransactions.AutoGenerateColumns = false;
            this.gvwTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvwTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.timestampDataGridViewTextBoxColumn,
            this.transTypeDataGridViewTextBoxColumn,
            this.localizedAmountDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn});
            this.gvwTransactions.DataSource = this.transactionBindingSource;
            this.gvwTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvwTransactions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gvwTransactions.Location = new System.Drawing.Point(10, 120);
            this.gvwTransactions.MultiSelect = false;
            this.gvwTransactions.Name = "gvwTransactions";
            this.gvwTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvwTransactions.Size = new System.Drawing.Size(557, 306);
            this.gvwTransactions.TabIndex = 8;
            this.gvwTransactions.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gvwTransactions_MouseClick);
            // 
            // mnuLedgerPopup
            // 
            this.mnuLedgerPopup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemEditTransaction,
            this.mnuItemDeleteTransaction});
            this.mnuLedgerPopup.Name = "mnuLedgerPopup";
            this.mnuLedgerPopup.Size = new System.Drawing.Size(182, 70);
            // 
            // mnuItemEditTransaction
            // 
            this.mnuItemEditTransaction.Name = "mnuItemEditTransaction";
            this.mnuItemEditTransaction.Size = new System.Drawing.Size(181, 22);
            this.mnuItemEditTransaction.Text = "-Edit Transaction-";
            this.mnuItemEditTransaction.Click += new System.EventHandler(this.mnuItemEditTransaction_Click);
            // 
            // mnuItemDeleteTransaction
            // 
            this.mnuItemDeleteTransaction.Name = "mnuItemDeleteTransaction";
            this.mnuItemDeleteTransaction.Size = new System.Drawing.Size(181, 22);
            this.mnuItemDeleteTransaction.Text = "-Delete Transaction-";
            this.mnuItemDeleteTransaction.Click += new System.EventHandler(this.mnuItemDeleteTransaction_Click);
            // 
            // timestampDataGridViewTextBoxColumn
            // 
            this.timestampDataGridViewTextBoxColumn.DataPropertyName = "Timestamp";
            this.timestampDataGridViewTextBoxColumn.HeaderText = "Timestamp";
            this.timestampDataGridViewTextBoxColumn.Name = "timestampDataGridViewTextBoxColumn";
            // 
            // transTypeDataGridViewTextBoxColumn
            // 
            this.transTypeDataGridViewTextBoxColumn.DataPropertyName = "TransType";
            this.transTypeDataGridViewTextBoxColumn.HeaderText = "TransType";
            this.transTypeDataGridViewTextBoxColumn.Name = "transTypeDataGridViewTextBoxColumn";
            // 
            // localizedAmountDataGridViewTextBoxColumn
            // 
            this.localizedAmountDataGridViewTextBoxColumn.DataPropertyName = "LocalizedAmount";
            this.localizedAmountDataGridViewTextBoxColumn.HeaderText = "LocalizedAmount";
            this.localizedAmountDataGridViewTextBoxColumn.Name = "localizedAmountDataGridViewTextBoxColumn";
            this.localizedAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            // 
            // frmCustomerLedger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(577, 473);
            this.Controls.Add(this.gvwTransactions);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbxCustomerData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCustomerLedger";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "-Customer ledger-";
            this.Load += new System.EventHandler(this.frmCustomerLedger_Load);
            this.gbxCustomerData.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvwTransactions)).EndInit();
            this.mnuLedgerPopup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCustomerData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblCustomerValue;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblAddressValue;
        private System.Windows.Forms.Label lblPhonenumber;
        private System.Windows.Forms.Label lblPhonenumberValue;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblBalanceValue;
        private System.Windows.Forms.BindingSource transactionBindingSource;
        private System.Windows.Forms.DataGridView gvwTransactions;
        private System.Windows.Forms.ContextMenuStrip mnuLedgerPopup;
        private System.Windows.Forms.ToolStripMenuItem mnuItemEditTransaction;
        private System.Windows.Forms.ToolStripMenuItem mnuItemDeleteTransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn timestampDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localizedAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
    }
}