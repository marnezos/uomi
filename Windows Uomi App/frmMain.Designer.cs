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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.tssStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbcMain = new System.Windows.Forms.TabControl();
            this.tbpCustomers = new System.Windows.Forms.TabPage();
            this.gvwCustomers = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbxFilter = new System.Windows.Forms.GroupBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuItemCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemAddCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.englishUKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemGreek = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemExport2Json = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCustomersPopup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuItemTransaction = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemAddCredit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemAddDebit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuItemViewCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemEditCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemDeleteCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.statusMain.SuspendLayout();
            this.tbcMain.SuspendLayout();
            this.tbpCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvwCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.gbxFilter.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.mnuCustomersPopup.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusMain
            // 
            this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssStatus});
            this.statusMain.Location = new System.Drawing.Point(0, 459);
            this.statusMain.Name = "statusMain";
            this.statusMain.Size = new System.Drawing.Size(788, 22);
            this.statusMain.TabIndex = 0;
            this.statusMain.Text = "statusStrip1";
            // 
            // tssStatus
            // 
            this.tssStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tssStatus.Name = "tssStatus";
            this.tssStatus.Size = new System.Drawing.Size(39, 17);
            this.tssStatus.Text = "Ready";
            // 
            // tbcMain
            // 
            this.tbcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcMain.Controls.Add(this.tbpCustomers);
            this.tbcMain.Location = new System.Drawing.Point(12, 27);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(764, 415);
            this.tbcMain.TabIndex = 1;
            // 
            // tbpCustomers
            // 
            this.tbpCustomers.Controls.Add(this.gvwCustomers);
            this.tbpCustomers.Controls.Add(this.gbxFilter);
            this.tbpCustomers.Location = new System.Drawing.Point(4, 22);
            this.tbpCustomers.Name = "tbpCustomers";
            this.tbpCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCustomers.Size = new System.Drawing.Size(756, 389);
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
            this.balanceDataGridViewTextBoxColumn});
            this.gvwCustomers.DataSource = this.customerBindingSource;
            this.gvwCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvwCustomers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gvwCustomers.Location = new System.Drawing.Point(3, 54);
            this.gvwCustomers.MultiSelect = false;
            this.gvwCustomers.Name = "gvwCustomers";
            this.gvwCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvwCustomers.Size = new System.Drawing.Size(750, 332);
            this.gvwCustomers.TabIndex = 2;
            this.gvwCustomers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvwCustomers_CellDoubleClick);
            this.gvwCustomers.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvwCustomers_ColumnHeaderMouseClick);
            this.gvwCustomers.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gvwCustomers_MouseClick);
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
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            this.balanceDataGridViewTextBoxColumn.HeaderText = "Balance";
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            this.balanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.AllowNew = false;
            this.customerBindingSource.DataSource = typeof(Windows_Uomi_App.Data.Customer);
            // 
            // gbxFilter
            // 
            this.gbxFilter.Controls.Add(this.txtFilter);
            this.gbxFilter.Controls.Add(this.btnClearFilter);
            this.gbxFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxFilter.Location = new System.Drawing.Point(3, 3);
            this.gbxFilter.Name = "gbxFilter";
            this.gbxFilter.Padding = new System.Windows.Forms.Padding(15, 6, 15, 11);
            this.gbxFilter.Size = new System.Drawing.Size(750, 51);
            this.gbxFilter.TabIndex = 1;
            this.gbxFilter.TabStop = false;
            this.gbxFilter.Text = "Filter";
            // 
            // txtFilter
            // 
            this.txtFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFilter.Location = new System.Drawing.Point(15, 19);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(654, 20);
            this.txtFilter.TabIndex = 3;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.AutoSize = true;
            this.btnClearFilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClearFilter.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClearFilter.Location = new System.Drawing.Point(669, 19);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(66, 21);
            this.btnClearFilter.TabIndex = 2;
            this.btnClearFilter.Text = "Clear Filter";
            this.btnClearFilter.UseVisualStyleBackColor = true;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemCustomers,
            this.mnuItemSettings,
            this.mnuItemAbout});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(788, 24);
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
            this.mnuItemAddCustomer.Click += new System.EventHandler(this.mnuItemAddCustomer_Click);
            // 
            // mnuItemSettings
            // 
            this.mnuItemSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemLanguage,
            this.mnuItemExport2Json});
            this.mnuItemSettings.Name = "mnuItemSettings";
            this.mnuItemSettings.Size = new System.Drawing.Size(71, 20);
            this.mnuItemSettings.Text = "-Settings-";
            // 
            // mnuItemLanguage
            // 
            this.mnuItemLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemEnglish,
            this.englishUKToolStripMenuItem,
            this.mnuItemGreek});
            this.mnuItemLanguage.Name = "mnuItemLanguage";
            this.mnuItemLanguage.Size = new System.Drawing.Size(197, 22);
            this.mnuItemLanguage.Text = "-Language-";
            // 
            // mnuItemEnglish
            // 
            this.mnuItemEnglish.Name = "mnuItemEnglish";
            this.mnuItemEnglish.Size = new System.Drawing.Size(138, 22);
            this.mnuItemEnglish.Text = "English (US)";
            this.mnuItemEnglish.Click += new System.EventHandler(this.mnuItemEnglish_Click);
            // 
            // englishUKToolStripMenuItem
            // 
            this.englishUKToolStripMenuItem.Name = "englishUKToolStripMenuItem";
            this.englishUKToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.englishUKToolStripMenuItem.Text = "English (UK)";
            this.englishUKToolStripMenuItem.Click += new System.EventHandler(this.englishUKToolStripMenuItem_Click);
            // 
            // mnuItemGreek
            // 
            this.mnuItemGreek.Name = "mnuItemGreek";
            this.mnuItemGreek.Size = new System.Drawing.Size(138, 22);
            this.mnuItemGreek.Text = "Ελληνικά";
            this.mnuItemGreek.Click += new System.EventHandler(this.mnuItemGreek_Click);
            // 
            // mnuItemExport2Json
            // 
            this.mnuItemExport2Json.Name = "mnuItemExport2Json";
            this.mnuItemExport2Json.Size = new System.Drawing.Size(197, 22);
            this.mnuItemExport2Json.Text = "-Export db to .json File-";
            this.mnuItemExport2Json.Click += new System.EventHandler(this.mnuItemExport2Json_Click);
            // 
            // mnuItemAbout
            // 
            this.mnuItemAbout.Name = "mnuItemAbout";
            this.mnuItemAbout.Size = new System.Drawing.Size(62, 20);
            this.mnuItemAbout.Text = "-About-";
            this.mnuItemAbout.Click += new System.EventHandler(this.mnuItemAbout_Click);
            // 
            // mnuCustomersPopup
            // 
            this.mnuCustomersPopup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemTransaction,
            this.toolStripMenuItem1,
            this.mnuItemViewCustomer,
            this.mnuItemEditCustomer,
            this.mnuItemDeleteCustomer});
            this.mnuCustomersPopup.Name = "mnuCustomersPopup";
            this.mnuCustomersPopup.Size = new System.Drawing.Size(173, 98);
            // 
            // mnuItemTransaction
            // 
            this.mnuItemTransaction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemAddCredit,
            this.mnuItemAddDebit});
            this.mnuItemTransaction.Name = "mnuItemTransaction";
            this.mnuItemTransaction.Size = new System.Drawing.Size(172, 22);
            this.mnuItemTransaction.Text = "-Transaction-";
            // 
            // mnuItemAddCredit
            // 
            this.mnuItemAddCredit.Name = "mnuItemAddCredit";
            this.mnuItemAddCredit.Size = new System.Drawing.Size(266, 22);
            this.mnuItemAddCredit.Text = "-Credit- (Customer Gives Us Money)";
            this.mnuItemAddCredit.Click += new System.EventHandler(this.mnuItemAddCredit_Click);
            // 
            // mnuItemAddDebit
            // 
            this.mnuItemAddDebit.Name = "mnuItemAddDebit";
            this.mnuItemAddDebit.Size = new System.Drawing.Size(266, 22);
            this.mnuItemAddDebit.Text = "-Debit- (Customer Owes Us Money)";
            this.mnuItemAddDebit.Click += new System.EventHandler(this.mnuItemAddDebit_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(169, 6);
            // 
            // mnuItemViewCustomer
            // 
            this.mnuItemViewCustomer.Name = "mnuItemViewCustomer";
            this.mnuItemViewCustomer.Size = new System.Drawing.Size(172, 22);
            this.mnuItemViewCustomer.Text = "-View Customer-";
            this.mnuItemViewCustomer.Click += new System.EventHandler(this.mnuItemViewCustomer_Click);
            // 
            // mnuItemEditCustomer
            // 
            this.mnuItemEditCustomer.Name = "mnuItemEditCustomer";
            this.mnuItemEditCustomer.Size = new System.Drawing.Size(172, 22);
            this.mnuItemEditCustomer.Text = "-Edit Customer-";
            this.mnuItemEditCustomer.Click += new System.EventHandler(this.mnuItemEditCustomer_Click);
            // 
            // mnuItemDeleteCustomer
            // 
            this.mnuItemDeleteCustomer.Name = "mnuItemDeleteCustomer";
            this.mnuItemDeleteCustomer.Size = new System.Drawing.Size(172, 22);
            this.mnuItemDeleteCustomer.Text = "-Delete Customer-";
            this.mnuItemDeleteCustomer.Click += new System.EventHandler(this.mnuItemDeleteCustomer_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 481);
            this.Controls.Add(this.tbcMain);
            this.Controls.Add(this.statusMain);
            this.Controls.Add(this.mnuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmMain";
            this.Text = "-Uomi-";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.statusMain.ResumeLayout(false);
            this.statusMain.PerformLayout();
            this.tbcMain.ResumeLayout(false);
            this.tbpCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvwCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.gbxFilter.ResumeLayout(false);
            this.gbxFilter.PerformLayout();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.mnuCustomersPopup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusMain;
        private System.Windows.Forms.TabControl tbcMain;
        private System.Windows.Forms.TabPage tbpCustomers;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuItemCustomers;
        private System.Windows.Forms.ToolStripMenuItem mnuItemAddCustomer;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.GroupBox gbxFilter;
        private System.Windows.Forms.DataGridView gvwCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip mnuCustomersPopup;
        private System.Windows.Forms.ToolStripMenuItem mnuItemEditCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuItemDeleteCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuItemViewCustomer;
        private System.Windows.Forms.ToolStripStatusLabel tssStatus;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem mnuItemTransaction;
        private System.Windows.Forms.ToolStripMenuItem mnuItemAddCredit;
        private System.Windows.Forms.ToolStripMenuItem mnuItemAddDebit;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuItemSettings;
        private System.Windows.Forms.ToolStripMenuItem mnuItemAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuItemLanguage;
        private System.Windows.Forms.ToolStripMenuItem mnuItemEnglish;
        private System.Windows.Forms.ToolStripMenuItem mnuItemGreek;
        private System.Windows.Forms.ToolStripMenuItem englishUKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuItemExport2Json;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

