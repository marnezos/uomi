﻿using System;
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
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Translator.Instance.Locale = "en";
            TranslateForm();
            //Data.RetailCustomer retailCustomer = new Data.RetailCustomer();
            //retailCustomer.Address = "my address";
            //retailCustomer.FirstName = "Nikos";
            //retailCustomer.LastName = "Marne";
            //retailCustomer.Phonenumber = "24234234";
            //retailCustomer.Save();

            RefreshCustomers();
        }


        private void RefreshCustomers()
        {
            var customers = Data.Customer.ToList();
            foreach (Data.Customer customer in customers)
            {
                Console.WriteLine(customer.Name);
                Console.WriteLine(customer.Address);
                Console.WriteLine(customer.Phonenumber);
                customerBindingSource.Add(customer);
            }
        }

        private void TranslateForm()
        {
            this.Text = Translator.Instance.Translate("frmMain_Caption");
            tbpCustomers.Text = Translator.Instance.Translate("tbpCustomers_Text");
            tbpLedger.Text = Translator.Instance.Translate("tbpLedger_Text");
            mnuItemAddCustomer.Text = Translator.Instance.Translate("mnuItemAddCustomer_Text");
            mnuItemCustomers.Text = Translator.Instance.Translate("mnuItemCustomers_Text");
        }


    }
}
