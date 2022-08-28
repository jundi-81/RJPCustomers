namespace RJPCustomers.Bll.Stores
{
    using RJPCustomers.Bll.Models;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IAccountStore
    {
        Task CreateAccount(Account account);
        Task<Account> GetAccount(Guid accountId);
        Task<IEnumerable<Account>> GetAccounts(Guid customerId);
        Task UpdateBalance(Guid accountId, decimal balance);
    }
}
