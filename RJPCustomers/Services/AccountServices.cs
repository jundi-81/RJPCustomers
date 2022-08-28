namespace RJPCustomers.Services
{
    using RJPCustomers.Data;
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

            var result = await accountStore.CreateAccount(accountId, customerId, initialCredit);
            if (result)
            {
                if (initialCredit != 0)
                {
                    //call transaction
                }

                return accountId;
            }
            return Guid.Empty;
        }

        /// <summary>
        /// update the balance for the selected account
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="balance"></param>
        /// <returns></returns>
        public async Task<bool> UpdateBalance(Guid accountId, decimal balance)
        {
            return await accountStore.UpdateBalance(accountId, balance);
        }

        /// <summary>
        /// get the balance for the selected account
        /// </summary>
        /// <param name="accountId"></param>
        /// <returns></returns>
        public async Task<decimal> GetBalance(Guid accountId)
        {
            return await accountStore.GetBalance(accountId);
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
