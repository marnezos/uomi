using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
using System.Globalization;

namespace Windows_Uomi_App.Data
{
    public abstract class Customer
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string Phonenumber { get; set; }
        public List<Transaction> Transactions;

        public string Total
        {
            get
            {
                int total;
                if (Transactions != null && Transactions.Count > 0)
                {
                    total= Transactions.Sum(item => item.Amount);
                }
                else
                {
                    total= 0;
                }

                return Translator.Instance.LocalizeCurrency(total);
            }
        }
        public abstract string Name { get; }


        public static IEnumerable<Customer> ToList()
        {
            using (var db = new LiteDB.LiteDatabase(AppDomain.CurrentDomain.BaseDirectory + @"\uomi.db"))
            {
                var col = db.GetCollection<Customer>("customers");
                return col.FindAll();
            }
        }



    }
}
