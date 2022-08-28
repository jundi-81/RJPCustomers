namespace RJPCustomers.Memory
{
    using RJPCustomers.Bll.Models;
    using RJPCustomers.Bll.Stores;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class UserStore : IUserStore
    {
        // just for testing
        private List<User> users;

        public UserStore()
        {
            users = new List<User>();
        }

        public async Task CreateUser(User user)
        {
            users.Add(user);

            await Task.CompletedTask;
        }

        public async Task<IEnumerable<Account>> GetAccounts(Guid customerId)
        {
            await Task.CompletedTask;

            return new List<Account>();
        }

        public async  Task<IEnumerable<Transaction>> GetTransactions(Guid customerId)
        {
            await Task.CompletedTask;

            return new List<Transaction>();
        }

       public async Task<User> GetUser(Guid customerId)
        {
            await Task.CompletedTask;

            return users.FirstOrDefault(o => o.CustomerId.Equals(customerId));
        }
    }
}
