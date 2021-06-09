using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    /// <summary>
    /// Minimum age is 18, no withdrawing more than is on the balance
    /// </summary>
    public class DebitCard : Card
    {
        public DebitCard(ulong accountNumber, ulong cardNumber, string cardHolderName, DateTime expiration) : base(accountNumber, cardNumber, cardHolderName, expiration)
        {
            AccountNumber = accountNumber;
            CardNumber = Convert.ToUInt64($"2400{cardNumber}");
            CardHolderName = cardHolderName;
            Expiration = expiration;
        }
    }
}
