namespace RJPCustomers.Data
{
    using RJPCustomers.Models;
    using System;
    using System.Threading.Tasks;

    public class AccountStore : IAccountStore
    {
        public Task<bool> CreateAccount(Guid accountId, Guid customerId, decimal balance = 0)
        {
            throw new NotImplementedException();
        }

        public Task<Account> GetAccount(Guid accountId)
        {
            throw new NotImplementedException();
        }

        public Task<decimal> GetBalance(Guid accountId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateBalance(Guid accountId, decimal balance)
        {
            throw new NotImplementedException();
        }
    }
}
