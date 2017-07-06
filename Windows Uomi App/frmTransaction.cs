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
            txtAmount.Culture = Translator.Instance.SelectedCultureInfo;
            TranslateForm();
            UpdateInterface();
        }

        private void UpdateInterface()
        {
            if (TransactionData.TransType== Data.Transaction.TransactionType.Credit )
            {
                lblTransactionType.Text = Translator.Instance.Translate("credit");
            }
            else
            {
                lblTransactionType.Text = Translator.Instance.Translate("debit");
            }
            lblCustomerName.Text = CustomerName;
        }

        private void UpdateTransactionData()
        {
            TransactionData.Amount = int.Parse(txtAmount.Text.Replace(",","").Replace(".",""));
            TransactionData.Timestamp = dtpTransaction.Value;
            TransactionData.Comment = "";
        }


        private void TranslateForm()
        {
            this.Text = Translator.Instance.Translate("frmTransaction_Caption");
            gbxCustomer.Text = Translator.Instance.Translate("gbxCustomer_Text");
            gbxDetails.Text= Translator.Instance.Translate("gbxDetails_Text");
            gbxTransactionType.Text = Translator.Instance.Translate("gbxTransactionType_Text");
            btnCancel.Text = Translator.Instance.Translate("btnCancel_Text");
            btnSave.Text = Translator.Instance.Translate("btnSave_Text");
            lblDate.Text = Translator.Instance.Translate("lblDate_Text");
            lblAmount.Text = Translator.Instance.Translate("lblAmount_Text");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateTransactionData();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
