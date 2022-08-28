namespace RJPCustomers.Bll.Services
{
    using RJPCustomers.Bll.Models;
    using RJPCustomers.Bll.Stores;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public sealed class TransactionServices
    {
        private readonly ITransactionStore transactionStore;

        public TransactionServices(ITransactionStore transactionStore)
        {
            this.transactionStore = transactionStore;
        }

        /// <summary>
        /// create a  transaction for an existing customer - account
        /// </summary>
        /// <param name="transaction"></param>
        public async Task CreateTansaction(Transaction transaction)
        {
            await transactionStore.CreateTransaction(transaction);
            //update balance
        }

        /// <summary>
        /// get all account transactions
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Transaction>> GetTransactions(Guid accountId)
        {
            return await transactionStore.GetTransactions(accountId);
        }
    }
}
