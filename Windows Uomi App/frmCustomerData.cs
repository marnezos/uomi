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
    public partial class frmCustomerData : Form
    {

        //Customer Data form has an underlying Customer object
        public Data.Customer CustomerData { get; set; }

        public frmCustomerData()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frmCustomerData_Load(object sender, EventArgs e)
        {
            TranslateForm();
            UpdateInterface();
        }

        //Object -> User Interface
        private void UpdateInterface()
        {
            if (CustomerData is Data.RetailCustomer)
            {
                rdbRetail.Checked = true;
                gbxRetailData.Visible = true;
                gbxWholesaleData.Visible = false;
                txtFirstName.Text = ((Data.RetailCustomer)CustomerData).FirstName;
                txtLastName.Text = ((Data.RetailCustomer)CustomerData).LastName;
            }
            else
            {
                rdbWholesale.Checked = true;
                gbxRetailData.Visible = false;
                gbxWholesaleData.Visible = true;
                txtVatNumber.Text = ((Data.WholesaleCustomer)CustomerData).VatNumber;
                txtBusinessName.Text = ((Data.WholesaleCustomer)CustomerData).BusinessName;
            }

            txtAddress.Text = CustomerData.Address;
            txtPhonenumber.Text = CustomerData.Phonenumber;

        }

        //User Interface -> Object
        private void UpdateCustomerData()
        {
            CustomerData.Address = txtAddress.Text;
            CustomerData.Phonenumber = txtPhonenumber.Text;
            if (rdbRetail.Checked)
            {
                ((Data.RetailCustomer)CustomerData).FirstName = txtFirstName.Text;
                ((Data.RetailCustomer)CustomerData).LastName = txtLastName.Text;
            }
            else
            {
                ((Data.WholesaleCustomer)CustomerData).VatNumber = txtVatNumber.Text;
                ((Data.WholesaleCustomer)CustomerData).BusinessName = txtBusinessName.Text;
            }
        }

        //Will work just for the new customer (for now)
        private void CustomerTypeChanged(object sender, EventArgs e)
        {
            if (rdbRetail.Checked && CustomerData is Data.WholesaleCustomer)
            {
                Data.Customer oldCustomerData = CustomerData;
                CustomerData = new Data.RetailCustomer();
                CustomerData.Address = oldCustomerData.Address;
                CustomerData.Phonenumber = oldCustomerData.Phonenumber;
            }
            else if (rdbWholesale.Checked && CustomerData is Data.RetailCustomer )
            {
                Data.Customer oldCustomerData = CustomerData;
                CustomerData = new Data.WholesaleCustomer();
                CustomerData.Address = oldCustomerData.Address;
                CustomerData.Phonenumber = oldCustomerData.Phonenumber;
            }

            UpdateInterface();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateCustomerData();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void TranslateForm()
        {
            this.Text = Translator.Instance.Translate("frmCustomerData_Caption");
            rdbRetail.Text = Translator.Instance.Translate("rdbRetail_Text");
            rdbWholesale.Text = Translator.Instance.Translate("rdbWholesale_Text");
            lblFirstName.Text = Translator.Instance.Translate("lblFirstName_Text");
            lblLastName.Text = Translator.Instance.Translate("lblLastName_Text");
            lblAddress.Text = Translator.Instance.Translate("lblAddress_Text");
            lblBusinessName.Text = Translator.Instance.Translate("lblBusinessName_Text");
            lblVatNumber.Text = Translator.Instance.Translate("lblVatNumber_Text");
            lblPhonenumber.Text = Translator.Instance.Translate("lblPhonenumber_Text");
            gbxCustomerType.Text = Translator.Instance.Translate("gbxCustomerType_Text");
            gbxRetailData.Text = Translator.Instance.Translate("gbxRetailData_Text");
            gbxWholesaleData.Text = Translator.Instance.Translate("gbxWholesaleData_Text");
            gbxConctactData.Text = Translator.Instance.Translate("gbxConctactData_Text");
            btnCancel.Text = Translator.Instance.Translate("btnCancel_Text");
            btnSave.Text = Translator.Instance.Translate("btnSave_Text");
        }

    }

}

