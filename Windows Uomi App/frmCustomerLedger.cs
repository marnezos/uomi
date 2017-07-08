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
    public partial class frmCustomerLedger : Form
    {

        public Data.Customer CustomerData { get; set; }

        public frmCustomerLedger()
        {
            InitializeComponent();
        }

        private void UpdateInterface()
        {
            lblAddressValue.Text = CustomerData.Address;
            lblPhonenumberValue.Text = CustomerData.Phonenumber;
            lblCustomerValue.Text = CustomerData.Name;
            lblBalanceValue.Text = CustomerData.Balance;

        }
        private void TranslateForm()
        {
            this.Text =  Translator.Instance.Translate("frmCustomerLedger_Caption");
            gbxCustomerData.Text = Translator.Instance.Translate("gbxCustomerData_Text");

            lblAddress.Text = Translator.Instance.Translate("lblAddress_Text");
            lblBalance.Text = Translator.Instance.Translate("lblBalance_Text");
            lblCustomer.Text = Translator.Instance.Translate("lblCustomer_Text");
            lblPhonenumber.Text = Translator.Instance.Translate("lblPhonenumber_Text");

            gvwTransactions.Columns["timestampDataGridViewTextBoxColumn"].HeaderText = Translator.Instance.Translate("gvwTransactions_timestampDataGridViewTextBoxColumn_text");
            gvwTransactions.Columns["transTypeDataGridViewTextBoxColumn"].HeaderText = Translator.Instance.Translate("gvwTransactions_transTypeDataGridViewTextBoxColumn_text");
            gvwTransactions.Columns["localizedAmountDataGridViewTextBoxColumn"].HeaderText = Translator.Instance.Translate("gvwTransactions_localizedAmountDataGridViewTextBoxColumn_text");
            gvwTransactions.Columns["commentDataGridViewTextBoxColumn"].HeaderText = Translator.Instance.Translate("gvwTransactions_commentDataGridViewTextBoxColumn_text");

            mnuItemDeleteTransaction.Text = Translator.Instance.Translate("mnuItemDeleteTransaction_Text");
            mnuItemEditTransaction.Text = Translator.Instance.Translate("mnuItemEditTransaction_Text");

            btnClose.Text = Translator.Instance.Translate("Close");

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frmCustomerLedger_Load(object sender, EventArgs e)
        {
            TranslateForm();
            UpdateInterface();
            RefreshLedger();
        }
        private void RefreshLedger()
        {

            int savedRow = 0;
            if (gvwTransactions.Rows.Count > 0) savedRow = gvwTransactions.FirstDisplayedCell.RowIndex;

            transactionBindingSource.Clear();
            IEnumerable<Data.Transaction> transactions = CustomerData.Transactions;
            if (transactions !=null && transactions.Count(x => true) > 0)
            {
                transactions = transactions.OrderBy(x => x.Timestamp);
                transactionBindingSource.DataSource = transactions;
            }
            else
            {
                gvwTransactions.Rows.Clear();
            }

            if (savedRow != 0 && savedRow < gvwTransactions.Rows.Count) gvwTransactions.FirstDisplayedScrollingRowIndex = savedRow;

        }

        private void gvwTransactions_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && gvwTransactions.SelectedRows.Count > 0)
            {
                mnuLedgerPopup.Show(gvwTransactions, e.X, e.Y);
            }
        }

        private void mnuItemEditTransaction_Click(object sender, EventArgs e)
        {
            Data.Transaction selectedTransaction = (Data.Transaction)gvwTransactions.SelectedRows[0].DataBoundItem;

            using (frmTransaction transactionForm = new frmTransaction())
            {
                transactionForm.TransactionData = selectedTransaction;
                transactionForm.CustomerName = CustomerData.Name;
                transactionForm.ShowDialog();
                if (transactionForm.DialogResult == DialogResult.OK)
                {
                    CustomerData.UpdateToDatabase();
                    RefreshLedger();
                    UpdateInterface();
                }
            }
        }

        private void mnuItemDeleteTransaction_Click(object sender, EventArgs e)
        {
            Data.Transaction selectedTransaction = (Data.Transaction)gvwTransactions.SelectedRows[0].DataBoundItem;

            string deleteConfirmationString = Translator.Instance.Translate("confirm_delete_transaction");
            string deleteConfirmationCaption = Translator.Instance.Translate("confirm_delete_transaction_caption");

            if (MessageBox.Show(String.Format(deleteConfirmationString, selectedTransaction.Timestamp ,selectedTransaction.LocalizedAmount ), deleteConfirmationCaption, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                CustomerData.Transactions.Remove(selectedTransaction);
                CustomerData.UpdateToDatabase();
                RefreshLedger();
                UpdateInterface();
            }

        }
    }
}
