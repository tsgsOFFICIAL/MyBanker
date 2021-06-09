using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class Card
    {
        #region Attributes
        public int AccountNumber { get; private set; } // Account Number
        public short RegistrationNumber { get; private set; } // Registration number
        public short SecurityNumber { get; private set; } // CVC, never used, but used in real life
        public string CardHolderName { get; private set; } // Card holders full name
        public decimal Balance { get; private set; } // The cards balance
        public long MaxWithdrawal { get; private set; } // Maximum allowed withdrawal
        public ulong CardNumber { get; private set; } // 16 or 19 digits
        public DateTime Expiration { get; private set; } // Expiration date for the card
        #endregion
        // Constructor
        public Card(short registrationNumber, int accountNumber, short securityNumber, ulong cardNumber, string cardHolderName, DateTime expiration)
        {
            RegistrationNumber = registrationNumber;
            AccountNumber = accountNumber;
            SecurityNumber = securityNumber;
            CardNumber = cardNumber;
            CardHolderName = cardHolderName;
            Expiration = expiration;
        }

        #region Methods
        /// <summary>
        /// Add money to the card
        /// </summary>
        /// <param name="amount">The amount the be added</param>
        /// <returns>This method returns a string, saying what has happened</returns>
        public string AddMoney(decimal amount)
        {
            // This method has no actual function, and is just here to illustrate what you could achieve
            return $"Successfully added {amount} amount";
        }
        /// <summary>
        /// Remove money from the card
        /// </summary>
        /// <param name="amount">The amount to be removed</param>
        /// <returns>This method returns a string, saying what has happened</returns>
        public string RemoveMoney(decimal amount)
        {
            // This method has no actual function, and is just here to illustrate what you could achieve
            return $"Successfully removed {amount} amount";
        }
        #endregion
    }
}
