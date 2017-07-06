using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Uomi_App.Data
{
    class WholesaleCustomer : Customer
    {
        public string VatNumber { get; set; }
        public string BusinessName { get; set; }

        public override string Name => BusinessName;

    }
}
