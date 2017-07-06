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

        public override string Name => string.Format("{0} {1}", LastName, FirstName);


        public bool Save()
        {
            try
            {

                using (var db = new LiteDatabase(AppDomain.CurrentDomain.BaseDirectory + @"\uomi.db"))
                {
                    var col = db.GetCollection<Customer>("customers");
                    col.Insert(this);
                    col.EnsureIndex(x => x.Id);
                }
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}
