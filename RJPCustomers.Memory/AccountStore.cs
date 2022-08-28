namespace RJPCustomers.Memory
{
    using RJPCustomers.Bll.Models;
    using RJPCustomers.Bll.Stores;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class AccountStore : IAccountStore
    {
        //dictionary was better for testing
        private List<Account> accounts;

        public AccountStore()
        {
            accounts = new List<Account>();
        }

        public async Task CreateAccount(Account account)
        {
            accounts.Add(account);

            await Task.CompletedTask;
        }

        public async Task<Account> GetAccount(Guid accountId)
        {
            await Task.CompletedTask;

            return accounts.FirstOrDefault(w => w.Id.Equals(accountId));
        }

        public async Task<IEnumerable<Account>> GetAccounts(Guid customerId)
        {
            await Task.CompletedTask;

            return accounts.Where(w => w.customerId.Equals(customerId));
        }

        public async Task UpdateBalance(Guid accountId, decimal balance)
        {
            var account = accounts.FirstOrDefault(w => w.Id.Equals(accountId));
            if ( account != null)
            {
                account.Balance = balance;
            }

            await Task.CompletedTask;
        }
    }
}
