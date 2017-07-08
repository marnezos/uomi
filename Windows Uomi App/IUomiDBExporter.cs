using System.Collections.Generic;

namespace Windows_Uomi_App
{
    interface IUomiDBExporter
    {
        bool Export(IEnumerable<Data.Customer> customerList, string filename);
    }
}
