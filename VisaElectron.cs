using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class VisaElectron : Card
    {
        private string[] _prefixes = new string[]
        {
            "4026",
            "417500",
            "4508",
            "4844",
            "4913",
            "4917"
        };
        public VisaElectron(ulong accountNumber, ulong cardNumber, string cardHolderName, DateTime expiration) : base(accountNumber, cardNumber, cardHolderName, expiration)
        {
            AccountNumber = accountNumber;
            CardNumber = Convert.ToUInt64($"{_prefixes[new Random().Next(0, _prefixes.Length)]}{cardNumber}".Substring(0, 16));
            CardHolderName = cardHolderName;
            Expiration = expiration;
        }
    }
}
