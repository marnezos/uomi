using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace Windows_Uomi_App.Data
{
    class RetailCustomer: Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Retail customer's name is Lastname + Firstname
        public override string Name => string.Format("{0} {1}", LastName, FirstName);

    }
}
