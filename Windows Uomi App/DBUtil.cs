using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Uomi_App
{
    class DBUtil
    {
        //Only export supported for now
        public bool Export (IUomiDBExporter exporter, IEnumerable<Data.Customer> customerList, string fileName)
        {
            return exporter.Export(customerList, fileName);
        }

        //TODO: Import (will be more difficult as the customers collection in the db contains docs of both RetailCustomer and WholesaleCustomer type (for some obscure reason ;p)
    }
}
