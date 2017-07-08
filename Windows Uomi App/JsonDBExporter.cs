using System;
using System.Collections.Generic;
using Windows_Uomi_App.Data;
using System.Web.Script.Serialization;

namespace Windows_Uomi_App
{
    class JsonDBExporter : IUomiDBExporter
    {
        public bool Export(IEnumerable<Customer> customerList, string filename)
        {
            try
            {
                JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
                var json = jsSerializer.Serialize(customerList);

                using (System.IO.TextWriter textWriter = new System.IO.StreamWriter(filename))
                {
                    textWriter.Write(json);
                    textWriter.Flush();
                    textWriter.Close();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
