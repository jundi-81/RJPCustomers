namespace RJPCustomers.Data
{
    using RJPCustomers.Models;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class UserStore : IUserStore
    {
        public Task<bool> CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Account>> GetAccounts(Guid customerId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Transaction>> GetTransactions(Guid customerId)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUser(Guid customerId)
        {
            throw new NotImplementedException();
        }
    }
}
