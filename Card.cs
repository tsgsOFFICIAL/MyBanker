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
        public ulong AccountNumber { get; protected set; } // Account Number
        public short RegistrationNumber { get; protected set; } // Registration number
        public short SecurityNumber { get; protected set; } // CVC, never used, but used in real life
        public string CardHolderName { get; protected set; } // Card holders full name
        public decimal Balance { get; protected set; } // The cards balance
        public ulong CardNumber { get; protected set; } // 16 or 19 digits
        public DateTime Expiration { get; protected set; } // Expiration date for the card
        public enum CardType
        {
            DebitCard,
            Mastercard,
            Maestro,
            Visa,
            VisaElectron
        }
        #endregion
        // Constructor
        public Card(short registrationNumber, ulong accountNumber, short securityNumber, ulong cardNumber, string cardHolderName, DateTime expiration)
        {
            RegistrationNumber = registrationNumber;
            AccountNumber = accountNumber;
            SecurityNumber = securityNumber;
            CardNumber = cardNumber;
            CardHolderName = cardHolderName;
            Expiration = expiration;
        }
        public Card(ulong accountNumber, ulong cardNumber, string cardHolderName, DateTime expiration)
        {
            AccountNumber = accountNumber;
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
