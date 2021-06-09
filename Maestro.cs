using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class Maestro : Card
    {
        private string[] _prefixes = new string[]
        {
            "5018",
            "5020",
            "5038",
            "5893",
            "6304",
            "6759",
            "6761",
            "6762",
            "6763"
        };
        public Maestro(ulong accountNumber, ulong cardNumber, string cardHolderName, DateTime expiration) : base(accountNumber, cardNumber, cardHolderName, expiration)
        {
            AccountNumber = accountNumber;
            CardNumber = Convert.ToUInt64($"{_prefixes[new Random().Next(0, _prefixes.Length)]}{cardNumber}");
            CardHolderName = cardHolderName;
            Expiration = expiration;
        }
    }
}
