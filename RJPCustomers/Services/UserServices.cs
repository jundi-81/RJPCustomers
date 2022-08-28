namespace RJPCustomers.Services
{
    using RJPCustomers.Data;
    using RJPCustomers.Models;
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
            result.Accounts = await GetAccounts(customerId);
            result.TotalBalance = await GetTotalBalance(customerId);

            return result;
        }

        /// <summary>
        /// get all accounts for the selected customer
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Account>> GetAccounts(Guid customerId)
        {
            return await userStore.GetAccounts(customerId);
        }

        /// <summary>
        /// get the total balance for all accounts
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public async Task<decimal> GetTotalBalance(Guid customerId)
        {
            var accounts = (await GetAccounts(customerId)).ToList();

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
