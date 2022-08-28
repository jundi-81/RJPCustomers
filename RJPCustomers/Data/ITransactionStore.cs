namespace RJPCustomers.Data
{
    using RJPCustomers.Models;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ITransactionStore
    {
        Task CreateTransaction(Transaction transaction);
        Task<IEnumerable<Transaction>> GetTransactions(Guid accountId);
    }
}
