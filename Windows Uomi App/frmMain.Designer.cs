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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.tbcMain = new System.Windows.Forms.TabControl();
            this.tbpCustomers = new System.Windows.Forms.TabPage();
            this.tbpLedger = new System.Windows.Forms.TabPage();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuItemCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemAddCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.tbcMain.SuspendLayout();
            this.mnuMain.SuspendLayout();
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
            this.tbpCustomers.Location = new System.Drawing.Point(4, 22);
            this.tbpCustomers.Name = "tbpCustomers";
            this.tbpCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCustomers.Size = new System.Drawing.Size(677, 356);
            this.tbpCustomers.TabIndex = 0;
            this.tbpCustomers.Text = "-Customers-";
            this.tbpCustomers.UseVisualStyleBackColor = true;
            // 
            // tbpLedger
            // 
            this.tbpLedger.Location = new System.Drawing.Point(4, 22);
            this.tbpLedger.Name = "tbpLedger";
            this.tbpLedger.Padding = new System.Windows.Forms.Padding(3);
            this.tbpLedger.Size = new System.Drawing.Size(677, 371);
            this.tbpLedger.TabIndex = 1;
            this.tbpLedger.Text = "-Ledger-";
            this.tbpLedger.UseVisualStyleBackColor = true;
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemCustomers});
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
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
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
    }
}

