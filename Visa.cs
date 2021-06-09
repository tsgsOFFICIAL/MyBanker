using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class Visa : Card, IWithdrawalLimit
    {
        public Visa(ulong accountNumber, ulong cardNumber, string cardHolderName, DateTime expiration) : base(accountNumber, cardNumber, cardHolderName, expiration)
        {
            AccountNumber = accountNumber;
            CardNumber = Convert.ToUInt64($"4{cardNumber}");
            CardHolderName = cardHolderName;
            Expiration = expiration;
        }
        void IWithdrawalLimit.WithdrawalLimit()
        {
            // Limit
        }
    }
}
