using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Windows_Uomi_App
{
    public partial class frmMain : Form
    {
        //Fields that store the sorting and filtering data for the customer grid
        private Data.Customer.CustomerColumn customerSortColumn;
        private bool customerSortAscending;
        private string customerFilter;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadSettings();
            TranslateForm();

            //Default sorting =by ID ascending and not filtered
            customerSortColumn = Data.Customer.CustomerColumn.Id;
            customerSortAscending = true;
            customerFilter = "";
            RefreshCustomers();
        }

        private void LoadSettings()
        {
            Translator.Instance.Locale = Properties.Settings.Default["locale"].ToString();
        }

        private void SaveSettings()
        {
            Properties.Settings.Default["locale"] = Translator.Instance.Locale;
            Properties.Settings.Default.Save();
        }

        //Refresh customers grid
        private void RefreshCustomers()
        {
            //Save position
            int savedRow = 0;
            if (gvwCustomers.Rows.Count > 0) savedRow = gvwCustomers.FirstDisplayedCell.RowIndex;

            customerBindingSource.Clear();

            //Use the sorting and filtering fields
            var customers = Data.Customer.ToList(customerSortColumn, customerSortAscending, customerFilter);
            List<Data.Customer> customerList = new List<Data.Customer>();

            foreach (Data.Customer customer in customers)
            {
                customerList.Add(customer);
            }
            customerBindingSource.DataSource = customerList;

            //Recall position
            if (savedRow != 0 && savedRow < gvwCustomers.Rows.Count) gvwCustomers.FirstDisplayedScrollingRowIndex = savedRow;

        }

        private void TranslateForm()
        {
            this.Text = Translator.Instance.Translate("frmMain_Caption");
            tbpCustomers.Text = Translator.Instance.Translate("tbpCustomers_Text");

            mnuItemAddCustomer.Text = Translator.Instance.Translate("mnuItemAddCustomer_Text");
            mnuItemCustomers.Text = Translator.Instance.Translate("mnuItemCustomers_Text");
            mnuItemTransaction.Text = Translator.Instance.Translate("mnuItemTransaction_Text");
            mnuItemAddCredit.Text = Translator.Instance.Translate("mnuItemAddCredit_Text");
            mnuItemAddDebit.Text = Translator.Instance.Translate("mnuItemAddDebit_Text");
            mnuItemEditCustomer.Text = Translator.Instance.Translate("mnuItemEditCustomer_Text");
            mnuItemDeleteCustomer.Text = Translator.Instance.Translate("mnuItemDeleteCustomer_Text");
            mnuItemViewCustomer.Text = Translator.Instance.Translate("mnuItemViewCustomer_Text");
            mnuItemAbout.Text = Translator.Instance.Translate("mnuItemAbout_Text");
            mnuItemSettings.Text = Translator.Instance.Translate("mnuItemSettings_Text");
            mnuItemLanguage.Text = Translator.Instance.Translate("mnuItemLanguage_Text");
            gvwCustomers.Columns["idDataGridViewTextBoxColumn"].HeaderText = Translator.Instance.Translate("gvwCustomers_idDataGridViewTextBoxColumn_text");
            gvwCustomers.Columns["nameDataGridViewTextBoxColumn"].HeaderText = Translator.Instance.Translate("gvwCustomers_nameDataGridViewTextBoxColumn_text");
            gvwCustomers.Columns["phonenumberDataGridViewTextBoxColumn"].HeaderText = Translator.Instance.Translate("gvwCustomers_phonenumberDataGridViewTextBoxColumn_text");
            gvwCustomers.Columns["addressDataGridViewTextBoxColumn"].HeaderText = Translator.Instance.Translate("gvwCustomers_addressDataGridViewTextBoxColumn_text");
            gvwCustomers.Columns["balanceDataGridViewTextBoxColumn"].HeaderText = Translator.Instance.Translate("gvwCustomers_balanceDataGridViewTextBoxColumn_text");
            gbxFilter.Text = Translator.Instance.Translate("gbxFilter_text");
            btnClearFilter.Text = Translator.Instance.Translate("btnClearFilter_text");
            mnuItemExport2Json.Text = Translator.Instance.Translate("mnuItemExport2Json_text");
        }

        private void mnuItemAddCustomer_Click(object sender, EventArgs e)
        {
            //Retrieve selected customer from grid
            Data.RetailCustomer retailCustomer = new Data.RetailCustomer();

            //Pass the selected customer to a new customer data form
            using (frmCustomerData dataEntryForm = new frmCustomerData())
            {
                dataEntryForm.CustomerData = retailCustomer;
                dataEntryForm.ShowDialog();
                if (dataEntryForm.DialogResult == DialogResult.OK)
                {
                    //Save 
                    dataEntryForm.CustomerData.Transactions = new List<Data.Transaction>();
                    dataEntryForm.CustomerData.AddToDatabase();
                    RefreshCustomers();
                }
            }

        }

        private void gvwCustomers_MouseClick(object sender, MouseEventArgs e)
        {
            //Show pop up
            if (e.Button == MouseButtons.Right && gvwCustomers.SelectedRows.Count > 0)
            {
                mnuCustomersPopup.Show(gvwCustomers, e.X, e.Y);
            }
        }

        private void mnuItemEditCustomer_Click(object sender, EventArgs e)
        {
            //Retrieve selected customer from grid
            var selectedCustomer = gvwCustomers.SelectedRows[0].DataBoundItem;

            //Pass the selected customer to a new customer data form
            using (frmCustomerData dataEntryForm = new frmCustomerData())
            {
                dataEntryForm.CustomerData = (Data.Customer)selectedCustomer;
                dataEntryForm.ShowDialog();
                if (dataEntryForm.DialogResult == DialogResult.OK)
                {
                    //Save any changes
                    dataEntryForm.CustomerData.UpdateToDatabase();
                    RefreshCustomers();
                }
            }
        }

        private void mnuItemDeleteCustomer_Click(object sender, EventArgs e)
        {
            //Retrieve selected customer from grid
            Data.Customer selectedCustomer = (Data.Customer)gvwCustomers.SelectedRows[0].DataBoundItem;

            string deleteConfirmationString = Translator.Instance.Translate("confirm_delete_customer");
            string deleteConfirmationCaption = Translator.Instance.Translate("confirm_delete_customer_caption");

            //Delete customer if user confirms acknowledges
            if (MessageBox.Show(String.Format(deleteConfirmationString, selectedCustomer.Name), deleteConfirmationCaption, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (selectedCustomer.DeleteFromDatabase())
                {
                    tssStatus.Text = String.Format(Translator.Instance.Translate("customer_deleted"), selectedCustomer.Name);
                }
                RefreshCustomers();
            }

        }

        //Apply filter if text is changed
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            customerFilter = txtFilter.Text;
            RefreshCustomers();
        }

        //Clear filter
        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            txtFilter.Text = string.Empty;
        }


        //Intercept column header click and sort accordingly
        private void gvwCustomers_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Data.Customer.CustomerColumn oldSortColumn = customerSortColumn;

            switch (gvwCustomers.Columns[e.ColumnIndex].DataPropertyName)
            {
                case "Id":
                    customerSortColumn = Data.Customer.CustomerColumn.Id;
                    break;
                case "Name":
                    customerSortColumn = Data.Customer.CustomerColumn.Name;
                    break;
                case "Address":
                    customerSortColumn = Data.Customer.CustomerColumn.Address;
                    break;
                case "Phonenumber":
                    customerSortColumn = Data.Customer.CustomerColumn.Phonenumber;
                    break;
                case "Balance":
                    customerSortColumn = Data.Customer.CustomerColumn.Balance;
                    break;
            }
            if (oldSortColumn == customerSortColumn)
            {
                customerSortAscending = !customerSortAscending;
            }
            else
            {
                customerSortAscending = true;
            }
            RefreshCustomers();

        }

        private void mnuItemAddCredit_Click(object sender, EventArgs e)
        {
            //Retrieve selected customer from grid
            Data.Customer selectedCustomer = (Data.Customer)gvwCustomers.SelectedRows[0].DataBoundItem;

            //Pass customer name to the new transaction form along with a new credit transaction
            using (frmTransaction transactionForm = new frmTransaction())
            {
                transactionForm.TransactionData = new Data.Transaction(Data.Transaction.TransactionType.Credit);
                transactionForm.CustomerName = selectedCustomer.Name;
                transactionForm.ShowDialog();
                if (transactionForm.DialogResult == DialogResult.OK)
                {
                    //Add transaction to the customer's transactions
                    if (selectedCustomer.Transactions is null)
                    {
                        selectedCustomer.Transactions = new List<Data.Transaction>();
                    }
                    selectedCustomer.Transactions.Add(transactionForm.TransactionData);
                    selectedCustomer.UpdateToDatabase();
                    RefreshCustomers();
                }
            }
        }

        //Show customer's ledger 
        private void mnuItemViewCustomer_Click(object sender, EventArgs e)
        {
            if (gvwCustomers.SelectedRows.Count > 0)
            {
                Data.Customer selectedCustomer = (Data.Customer)gvwCustomers.SelectedRows[0].DataBoundItem;
                ShowLedgerForm(selectedCustomer);
            }
        }

        //Show customer's ledger on double click
        private void gvwCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gvwCustomers.SelectedRows.Count > 0)
            {
                Data.Customer selectedCustomer = (Data.Customer)gvwCustomers.SelectedRows[0].DataBoundItem;
                ShowLedgerForm(selectedCustomer);
            }
        }

        //Shows the ledger for a customer
        private void ShowLedgerForm(Data.Customer Customer)
        {
            using (frmCustomerLedger ledgerForm = new frmCustomerLedger())
            {
                ledgerForm.CustomerData = Customer;
                ledgerForm.ShowDialog();
                RefreshCustomers();
            }
        }

        private void mnuItemAddDebit_Click(object sender, EventArgs e)
        {
            //Retrieve selected customer from grid
            Data.Customer selectedCustomer = (Data.Customer)gvwCustomers.SelectedRows[0].DataBoundItem;

            //Pass customer name to a new transaction form along with a new debit transaction
            using (frmTransaction transactionForm = new frmTransaction())
            {
                transactionForm.TransactionData = new Data.Transaction(Data.Transaction.TransactionType.Debit);
                transactionForm.CustomerName = selectedCustomer.Name;
                transactionForm.ShowDialog();
                if (transactionForm.DialogResult == DialogResult.OK)
                {
                    //Add transaction to the customer's transactions
                    if (selectedCustomer.Transactions is null)
                    {
                        selectedCustomer.Transactions = new List<Data.Transaction>();
                    }
                    selectedCustomer.Transactions.Add(transactionForm.TransactionData);
                    selectedCustomer.UpdateToDatabase();
                    RefreshCustomers();
                }
            }
        }

        private void mnuItemEnglish_Click(object sender, EventArgs e)
        {
            ChangeLocale("en-US");
        }

        private void mnuItemGreek_Click(object sender, EventArgs e)
        {
            ChangeLocale("el-GR");
        }

        private void englishUKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLocale("en-GB");
        }

        private void ChangeLocale(string newLocale)
        {
            Translator.Instance.Locale = newLocale;
            TranslateForm();
            RefreshCustomers();
            SaveSettings();
        }

        //Export to json file (for debug purposes)
        private void mnuItemExport2Json_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = ".json";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog1.FileName;
                DBUtil dbUtil = new DBUtil();

                if (dbUtil.Export(new JsonDBExporter(), Data.Customer.ToList(customerSortColumn, customerSortAscending, ""), fileName))
                {
                    tssStatus.Text = Translator.Instance.Translate("db_exported_successfully");
                }
                else
                {
                    tssStatus.Text = Translator.Instance.Translate("db_export_failed");
                    MessageBox.Show(Translator.Instance.Translate("db_export_failed"), Translator.Instance.Translate("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void mnuItemAbout_Click(object sender, EventArgs e)
        {
            using (frmAbout aboutForm = new frmAbout())
            {
                aboutForm.ShowDialog();
            }
        }
    }
}
