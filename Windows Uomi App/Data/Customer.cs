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

        public enum CustomerColumn { Id, Address, Phonenumber, Name, Balance }

        [BsonId]
        public int Id { get; set; }

        public string Address { get; set; }
        public string Phonenumber { get; set; }

        public List<Transaction> Transactions { get; set; }


        [BsonIgnore]
        public string Balance
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

                float fTotal = total;
                fTotal = fTotal / 100;

                return Translator.Instance.LocalizeCurrency(fTotal);
            }
        }

        public abstract string Name { get; }

        public Customer()
        {

        }

        public static IEnumerable<Customer> ToList(CustomerColumn orderBy, bool ascending, string filter="")
        {
            using (var db = new LiteDB.LiteDatabase(AppDomain.CurrentDomain.BaseDirectory + @"\uomi.db"))
            {
                var col = db.GetCollection<Customer>("customers");
                IEnumerable<Customer> retCustomers;

                if (string.IsNullOrEmpty(filter))
                {
                    retCustomers = col.FindAll().OrderBy(x => x.Address);
                }
                else
                {
                    retCustomers= col.Find(x => true).Where(x => CultureInfo.CurrentCulture.CompareInfo.IndexOf(x.Name, filter, CompareOptions.IgnoreCase)>=0
                                                     || CultureInfo.CurrentCulture.CompareInfo.IndexOf(x.Address, filter, CompareOptions.IgnoreCase)>=0
                                                     || CultureInfo.CurrentCulture.CompareInfo.IndexOf(x.Phonenumber, filter, CompareOptions.IgnoreCase)>= 0);
                }

                switch (orderBy)
                {
                    case CustomerColumn.Id:
                        retCustomers = ascending ? retCustomers.OrderBy(x => x.Id): retCustomers.OrderByDescending(x => x.Id);
                        break;
                    case CustomerColumn.Name:
                        retCustomers = ascending ? retCustomers.OrderBy(x => x.Name) : retCustomers.OrderByDescending(x => x.Name);
                        break;
                    case CustomerColumn.Address:
                        retCustomers = ascending ? retCustomers.OrderBy(x => x.Address) : retCustomers.OrderByDescending(x => x.Address);
                        break;
                    case CustomerColumn.Phonenumber:
                        retCustomers = ascending ? retCustomers.OrderBy(x => x.Phonenumber) : retCustomers.OrderByDescending(x => x.Phonenumber);
                        break;
                    case CustomerColumn.Balance:
                        retCustomers = ascending ? retCustomers.OrderBy(x => x.Balance) : retCustomers.OrderByDescending(x => x.Balance);
                        break;
                }
                return retCustomers;
            }
        }

        public bool AddToDatabase()
        {
            try
            {
                using (var db = new LiteDB.LiteDatabase(AppDomain.CurrentDomain.BaseDirectory + @"\uomi.db"))
                {
                    var col = db.GetCollection<Customer>("customers");
                    col.Insert(this);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateToDatabase()
        {
            try
            {
                using (var db = new LiteDB.LiteDatabase(AppDomain.CurrentDomain.BaseDirectory + @"\uomi.db"))
                {
                    var col = db.GetCollection<Customer>("customers");
                    col.Update(this);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteFromDatabase()
        {
            try
            {
                using (var db = new LiteDB.LiteDatabase(AppDomain.CurrentDomain.BaseDirectory + @"\uomi.db"))
                {
                    var col = db.GetCollection<Customer>("customers");
                    col.Delete(this.Id);
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
