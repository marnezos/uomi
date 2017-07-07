using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Windows_Uomi_App
{
    public partial class frmTransaction : Form
    {

        public Data.Transaction TransactionData { get; set; }
        public string CustomerName { get; set; }

        public frmTransaction()
        {
            InitializeComponent();
        }

        private void frmTransaction_Load(object sender, EventArgs e)
        {
            txtAmount.PreFix = Translator.Instance.SelectedCultureInfo.NumberFormat.CurrencySymbol;
            txtAmount.DecimalsSeparator = Translator.Instance.SelectedCultureInfo.NumberFormat.NumberDecimalSeparator.ToCharArray()[0];
            txtAmount.ThousandsSeparator = ' ';
            TranslateForm();
            UpdateInterface();
        }

        private void UpdateInterface()
        {
            if (TransactionData.TransType == Data.Transaction.TransactionType.Credit)
            {
                lblTransactionType.Text = Translator.Instance.Translate("credit");
            }
            else
            {
                lblTransactionType.Text = Translator.Instance.Translate("debit");
            }
            lblCustomerName.Text = CustomerName;
            if (TransactionData.Timestamp != new DateTime())
            {
                dtpTransaction.Value = TransactionData.Timestamp;
            }
            else
            {
                dtpTransaction.Value = DateTime.Now;
            }

            txtAmount.Text = TransactionData.Amount<0? (TransactionData.Amount * -1).ToString(): TransactionData.Amount.ToString();

        }

        private void UpdateTransactionData()
        {
            TransactionData.Amount = int.Parse(txtAmount.WorkingText.Replace(",", "").Replace(".", ""));
            if (TransactionData.TransType == Data.Transaction.TransactionType.Debit)
            {
                TransactionData.Amount *= -1;
            }
            TransactionData.Timestamp = dtpTransaction.Value;
            TransactionData.Comment = "";
        }


        private void TranslateForm()
        {
            this.Text = Translator.Instance.Translate("frmTransaction_Caption");
            gbxCustomer.Text = Translator.Instance.Translate("gbxCustomer_Text");
            gbxDetails.Text = Translator.Instance.Translate("gbxDetails_Text");
            gbxTransactionType.Text = Translator.Instance.Translate("gbxTransactionType_Text");
            btnCancel.Text = Translator.Instance.Translate("btnCancel_Text");
            btnSave.Text = Translator.Instance.Translate("btnSave_Text");
            lblDate.Text = Translator.Instance.Translate("lblDate_Text");
            lblAmount.Text = Translator.Instance.Translate("lblAmount_Text");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int i;
            
            if (int.TryParse(txtAmount.WorkingText.Replace(",", "").Replace(".", ""), out i))
            {
                UpdateTransactionData();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(Translator.Instance.Translate("Erroneous_Amount"), Translator.Instance.Translate("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            lblFormattedAmount.Text = txtAmount.formatText();
        }
    }
}
