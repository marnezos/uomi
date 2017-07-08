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
        // To be used when sorting
        public enum CustomerColumn { Id, Address, Phonenumber, Name, Balance }

        // Fields to store in json document
        [BsonId]
        public int Id { get; set; }

        public string Address { get; set; }
        public string Phonenumber { get; set; }

        // Each customer has a list of transactions
        public List<Transaction> Transactions { get; set; }

        // Balance is not to be saved in the json document, it will be computed every time
        [BsonIgnore]
        public string Balance
        {
            get
            {
                int total;
                if (Transactions != null && Transactions.Count > 0)
                {
                    total = Transactions.Sum(item => item.Amount);
                }
                else
                {
                    total = 0;
                }

                // Amount is always stored as integer
                float fTotal = total;
                fTotal = fTotal / 100;

                return Translator.Instance.LocalizeCurrency(fTotal);
            }
        }

        // Name must be overriden by derived classes and provided accordingly
        public abstract string Name { get; }

        public Customer(){}

        // Returns a list of customers from the DB.
        // This is the main DB functionality

        public static IEnumerable<Customer> ToList(CustomerColumn orderBy, bool ascending, string filter = "")
        {
            //Open DB
            using (var db = new LiteDB.LiteDatabase(AppDomain.CurrentDomain.BaseDirectory + @"\uomi.db"))
            {
                // Retrieve 'customers' collection
                var col = db.GetCollection<Customer>("customers");

                // Declare a return variable
                IEnumerable<Customer> retCustomers;

                //Check if a filter was provided
                if (string.IsNullOrEmpty(filter))
                {
                    //No filter, fetch everything
                    retCustomers = col.FindAll();
                }
                else
                {
                    //Apply filter in name or address or phonenumber
                    retCustomers = col.Find(x => true).Where(x => CultureInfo.CurrentCulture.CompareInfo.IndexOf(x.Name, filter, CompareOptions.IgnoreCase) >= 0
                                                      || CultureInfo.CurrentCulture.CompareInfo.IndexOf(x.Address, filter, CompareOptions.IgnoreCase) >= 0
                                                      || CultureInfo.CurrentCulture.CompareInfo.IndexOf(x.Phonenumber, filter, CompareOptions.IgnoreCase) >= 0);
                }

                //Order the output
                switch (orderBy)
                {
                    case CustomerColumn.Id:
                        retCustomers = ascending ? retCustomers.OrderBy(x => x.Id) : retCustomers.OrderByDescending(x => x.Id);
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

        //Adds customer instance to the DB
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

        //Updates customer instance to the database
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

        //Deletes customer instance from the database
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
