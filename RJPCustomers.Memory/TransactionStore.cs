namespace RJPCustomers.Memory
{
    using RJPCustomers.Bll.Models;
    using RJPCustomers.Bll.Stores;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Linq;

    public class TransactionStore : ITransactionStore
    {
        private List<Transaction> transactions;
        public TransactionStore()
        {
            transactions = new List<Transaction>();
        }

        public async Task CreateTransaction(Transaction transaction)
        {
            transactions.Add(transaction);

            await Task.CompletedTask;
        }

        public async Task<IEnumerable<Transaction>> GetTransactions(Guid accountId)
        {
            await Task.CompletedTask;

            return transactions.Where(w => w.AccountId.Equals(accountId));
        }

        public async Task<IEnumerable<Transaction>> GetTransactions(IEnumerable<Guid> accountIds)
        {
            await Task.CompletedTask;

            return transactions.Where(w => accountIds.Contains(w.AccountId));
        }
    }
}
