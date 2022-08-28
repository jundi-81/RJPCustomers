namespace RJPCustomers.Data
{
    using RJPCustomers.Models;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class TransactionStore : ITransactionStore
    {
        public Task CreateTransaction(Transaction transaction)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Transaction>> GetTransactions(Guid accountId)
        {
            throw new NotImplementedException();
        }
    }
}
