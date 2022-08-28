namespace RJPCustomers.Bll.Services
{
    using RJPCustomers.Bll.Models;
    using RJPCustomers.Bll.Stores;
    using System;
    using System.Threading.Tasks;

    public sealed class AccountServices
    {
        private readonly IAccountStore accountStore;

        public AccountServices(IAccountStore accountStore)
        {
            this.accountStore = accountStore;
        }

        /// <summary>
        /// create a new account for the customer
        /// </summary>
        /// <param name="customerId">the user id</param>
        /// <param name="initialCredit">the initial credit for the new account</param>
        /// <returns></returns>
        public async Task<Guid> CreateAccount(Guid customerId, int initialCredit)
        {
            var accountId = GenerateAccountId();

            await accountStore.CreateAccount(
                new Account
                {
                    Id = accountId,
                    customerId = customerId,
                    Balance = initialCredit
                });

            if (initialCredit != 0)
            {
                //call transaction
            }

            return accountId;
        }

        /// <summary>
        /// update the balance for the selected account
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="balance"></param>
        /// <returns></returns>
        public async Task UpdateBalance(Guid accountId, decimal balance)
        {
            await accountStore.UpdateBalance(accountId, balance);
        }

        #region private methods
        private Guid GenerateAccountId()
        {
            //it's better to check if the guid exists in db or not
            return Guid.NewGuid();
        }
        #endregion
    }
}
