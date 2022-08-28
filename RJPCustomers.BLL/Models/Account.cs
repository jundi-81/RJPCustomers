namespace RJPCustomers.Bll.Models
{
    using System;

    public class Account
    {
        public Guid Id { get; set; }
        public decimal Balance { get; set; }
        public Guid customerId { get; set; }
    }
}
