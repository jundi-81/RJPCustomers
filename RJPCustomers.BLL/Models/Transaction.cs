namespace RJPCustomers.Bll.Models
{
    using System;

    public class Transaction
    {
        public Guid AccountId { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}