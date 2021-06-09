using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class Mastercard : Card
    {
        private string[] _prefixes = new string[]
        {
            "51",
            "52",
            "53",
            "54",
            "55"
        };
        public Mastercard(ulong accountNumber, ulong cardNumber, string cardHolderName, DateTime expiration) : base(accountNumber, cardNumber, cardHolderName, expiration)
        {
            AccountNumber = accountNumber;
            CardNumber = Convert.ToUInt64($"{_prefixes[new Random().Next(0, _prefixes.Length)]}{cardNumber}");
            CardHolderName = cardHolderName;
            Expiration = expiration;
        }
    }
}
