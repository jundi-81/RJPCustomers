namespace RJPCustomers.Bll.Services
{
    using RJPCustomers.Bll.Models;
    using RJPCustomers.Bll.Stores;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public sealed class UserServices
    {
        private readonly IUserStore userStore;

        public UserServices(IUserStore userStore)
        {
            this.userStore = userStore;
        }

        /// <summary>
        /// get all user information even the total balance
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public async Task<User> GetUser(Guid customerId)
        {
            var result = await userStore.GetUser(customerId);
            if (result != null)
                result.TotalBalance = await GetTotalBalance(customerId);

            return result;
        }

        /// <summary>
        /// get the total balance for all accounts
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public async Task<decimal> GetTotalBalance(Guid customerId)
        {
            var accounts = (await userStore.GetAccounts(customerId)).ToList();

            return accounts.Sum(a => a.Balance);
        }

        /// <summary>
        /// get all transactions for the selected account
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Transaction>> GetTransactions(Guid customerId)
        {
            return await userStore.GetTransactions(customerId);
        }
    }
}
