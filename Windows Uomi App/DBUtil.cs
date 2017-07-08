using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Uomi_App
{
    class DBUtil
    {
        public bool Export (IUomiDBExporter exporter, IEnumerable<Data.Customer> customerList, string fileName)
        {
            return exporter.Export(customerList, fileName);
        }
    }
}
