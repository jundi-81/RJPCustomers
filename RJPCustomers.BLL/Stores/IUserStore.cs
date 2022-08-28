namespace RJPCustomers.Bll.Stores
{
    using RJPCustomers.Bll.Models;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IUserStore
    {
        Task<User> GetUser(Guid customerId);
        Task CreateUser(User user);
        Task<IEnumerable<Account>> GetAccounts(Guid customerId);
        Task<IEnumerable<Transaction>> GetTransactions(Guid customerId);
    }
}
