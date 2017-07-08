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

        //Fields for the json document
        [BsonId]
        public int Id { get; set; }

        public DateTime Timestamp { get; set; }
        public int Amount { get; set; }
        public string Comment { get; set; }
        public TransactionType TransType { get; set; }

        //Localized amount is not to be saved in the json document. It will be computed every time (depending on the selected locale).
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

        //Default constructor sets type = credit       
        public Transaction()
        {
            TransType = TransactionType.Credit;
        }

        public Transaction(TransactionType transType)
        {
            TransType = transType;
        }

    }
}
