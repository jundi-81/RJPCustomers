namespace RJPCustomers.Models
{
    using System;

    public class Account
    {
        public Guid Id { get; set; }
        public decimal Balance { get; set; }
        public bool IsDisabled { get; set; }
    }
}
