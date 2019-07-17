using System;
namespace BankAccount
{
    /// <summary>
    /// A bank account where you deposit or withdraw a money 
    /// </summary>
    public class Account
    #region Properties 

    {
        /// <summary>
        /// Unique number for the account 
        /// </summary>
        /// <value>The account number.</value>
        public int AccountNumber { get; set; }
        public string EmailAddress { get; set; }
        public string AccountType { get; set; }
        public decimal Balance { get; set; }
        public DateTime CreatedDate { get; set; }
        #endregion
        #region Methods 
        /// <summary>
        /// Deposit the specified Amount to your account.
        /// </summary>
        /// <returns>New Balance.</returns>
        /// <param name="amount">Amount to be deposited </param>
        public decimal Deposit(decimal amount )
        {
            Balance += amount;
            return Balance; 
        }
        public void Withdraw (decimal amount )
        { 
        Balance -= amount;
 }

            

        #endregion 
    }

}
