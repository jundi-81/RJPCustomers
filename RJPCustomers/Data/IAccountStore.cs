namespace RJPCustomers.Data
{
    using RJPCustomers.Models;
    using System;
    using System.Threading.Tasks;

    public interface IAccountStore
    {
        Task<bool> CreateAccount(Guid accountId, Guid customerId, decimal balance = 0);
        Task<Account> GetAccount(Guid accountId);
        Task<decimal> GetBalance(Guid accountId);
        Task<bool> UpdateBalance(Guid accountId, decimal balance);
    }
}
