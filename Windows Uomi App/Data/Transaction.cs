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

        public Transaction()
        {
            TransType = TransactionType.Credit;
        }

        public Transaction(TransactionType transType)
        {
            TransType = TransType;
        }
    }
}
