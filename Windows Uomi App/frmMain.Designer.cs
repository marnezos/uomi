namespace Windows_Uomi_App
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.tbcMain = new System.Windows.Forms.TabControl();
            this.tbpCustomers = new System.Windows.Forms.TabPage();
            this.gvwCustomers = new System.Windows.Forms.DataGridView();
            this.tbpLedger = new System.Windows.Forms.TabPage();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuItemCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemAddCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnuItemTransactions = new System.Windows.Forms.ToolStripMenuItem();
            this.addCreditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxFilter = new System.Windows.Forms.GroupBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.tbcMain.SuspendLayout();
            this.tbpCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvwCustomers)).BeginInit();
            this.mnuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.gbxFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusMain
            // 
            this.statusMain.Location = new System.Drawing.Point(0, 426);
            this.statusMain.Name = "statusMain";
            this.statusMain.Size = new System.Drawing.Size(709, 22);
            this.statusMain.TabIndex = 0;
            this.statusMain.Text = "statusStrip1";
            // 
            // tbcMain
            // 
            this.tbcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcMain.Controls.Add(this.tbpCustomers);
            this.tbcMain.Controls.Add(this.tbpLedger);
            this.tbcMain.Location = new System.Drawing.Point(12, 27);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(685, 382);
            this.tbcMain.TabIndex = 1;
            // 
            // tbpCustomers
            // 
            this.tbpCustomers.Controls.Add(this.gbxFilter);
            this.tbpCustomers.Controls.Add(this.gvwCustomers);
            this.tbpCustomers.Location = new System.Drawing.Point(4, 22);
            this.tbpCustomers.Name = "tbpCustomers";
            this.tbpCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCustomers.Size = new System.Drawing.Size(677, 356);
            this.tbpCustomers.TabIndex = 0;
            this.tbpCustomers.Text = "-Customers-";
            this.tbpCustomers.UseVisualStyleBackColor = true;
            // 
            // gvwCustomers
            // 
            this.gvwCustomers.AutoGenerateColumns = false;
            this.gvwCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvwCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.phonenumberDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.gvwCustomers.DataSource = this.customerBindingSource;
            this.gvwCustomers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gvwCustomers.Location = new System.Drawing.Point(3, 60);
            this.gvwCustomers.Name = "gvwCustomers";
            this.gvwCustomers.Size = new System.Drawing.Size(671, 293);
            this.gvwCustomers.TabIndex = 0;
            // 
            // tbpLedger
            // 
            this.tbpLedger.Location = new System.Drawing.Point(4, 22);
            this.tbpLedger.Name = "tbpLedger";
            this.tbpLedger.Padding = new System.Windows.Forms.Padding(3);
            this.tbpLedger.Size = new System.Drawing.Size(677, 356);
            this.tbpLedger.TabIndex = 1;
            this.tbpLedger.Text = "-Ledger-";
            this.tbpLedger.UseVisualStyleBackColor = true;
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemCustomers,
            this.mnuItemTransactions});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(709, 24);
            this.mnuMain.TabIndex = 2;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuItemCustomers
            // 
            this.mnuItemCustomers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemAddCustomer});
            this.mnuItemCustomers.Name = "mnuItemCustomers";
            this.mnuItemCustomers.Size = new System.Drawing.Size(86, 20);
            this.mnuItemCustomers.Text = "-Customers-";
            // 
            // mnuItemAddCustomer
            // 
            this.mnuItemAddCustomer.Name = "mnuItemAddCustomer";
            this.mnuItemAddCustomer.Size = new System.Drawing.Size(161, 22);
            this.mnuItemAddCustomer.Text = "-Add Customer-";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(Windows_Uomi_App.Data.Customer);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            this.phonenumberDataGridViewTextBoxColumn.DataPropertyName = "Phonenumber";
            this.phonenumberDataGridViewTextBoxColumn.HeaderText = "Phonenumber";
            this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.totalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mnuItemTransactions
            // 
            this.mnuItemTransactions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCreditToolStripMenuItem,
            this.addPaymentToolStripMenuItem});
            this.mnuItemTransactions.Name = "mnuItemTransactions";
            this.mnuItemTransactions.Size = new System.Drawing.Size(95, 20);
            this.mnuItemTransactions.Text = "-Transactions-";
            // 
            // addCreditToolStripMenuItem
            // 
            this.addCreditToolStripMenuItem.Name = "addCreditToolStripMenuItem";
            this.addCreditToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.addCreditToolStripMenuItem.Text = "-Add Credit-";
            // 
            // addPaymentToolStripMenuItem
            // 
            this.addPaymentToolStripMenuItem.Name = "addPaymentToolStripMenuItem";
            this.addPaymentToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.addPaymentToolStripMenuItem.Text = "-Add Payment-";
            // 
            // gbxFilter
            // 
            this.gbxFilter.Controls.Add(this.txtFilter);
            this.gbxFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxFilter.Location = new System.Drawing.Point(3, 3);
            this.gbxFilter.Name = "gbxFilter";
            this.gbxFilter.Size = new System.Drawing.Size(671, 51);
            this.gbxFilter.TabIndex = 1;
            this.gbxFilter.TabStop = false;
            this.gbxFilter.Text = "Filter";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(15, 19);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(595, 20);
            this.txtFilter.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 448);
            this.Controls.Add(this.tbcMain);
            this.Controls.Add(this.statusMain);
            this.Controls.Add(this.mnuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmMain";
            this.Text = "-Uomi-";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tbcMain.ResumeLayout(false);
            this.tbpCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvwCustomers)).EndInit();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.gbxFilter.ResumeLayout(false);
            this.gbxFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusMain;
        private System.Windows.Forms.TabControl tbcMain;
        private System.Windows.Forms.TabPage tbpCustomers;
        private System.Windows.Forms.TabPage tbpLedger;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuItemCustomers;
        private System.Windows.Forms.ToolStripMenuItem mnuItemAddCustomer;
        private System.Windows.Forms.DataGridView gvwCustomers;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem mnuItemTransactions;
        private System.Windows.Forms.ToolStripMenuItem addCreditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPaymentToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbxFilter;
        private System.Windows.Forms.TextBox txtFilter;
    }
}

