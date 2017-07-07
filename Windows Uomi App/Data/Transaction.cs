using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Uomi_App.Data
{
    public class Transaction
    {
        public enum TransactionType
        {
            Credit,
            Debit
        }

        [BsonId]
        public int Id { get; set; }

        public DateTime Timestamp { get; set; }
        public int Amount { get; set; }
        public string Comment { get; set; }
        public TransactionType TransType { get; set; }

        [BsonIgnore]
        public string LocalizedAmount
        {
            get
            {
                float fTotal = Amount;
                fTotal = fTotal / 100;
                return Translator.Instance.LocalizeCurrency(fTotal);
            }
        }

        public Transaction()
        {
            TransType = TransactionType.Credit;
        }

        public Transaction(TransactionType transType)
        {
            TransType = transType;
        }

        //public static IEnumerable<Transaction> ToList()
        //{
        //    using (var db = new LiteDB.LiteDatabase(AppDomain.CurrentDomain.BaseDirectory + @"\uomi.db"))
        //    {
        //        var col = db.GetCollection<Customer>("customers");

        //        IEnumerable<Customer> retTransactions;
        //        retTransactions = col.FindAll().OrderBy(x => x.Address);
        //    }
        //}

    }
}
