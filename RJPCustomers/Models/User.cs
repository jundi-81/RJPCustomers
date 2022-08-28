namespace RJPCustomers.Models
{
    using System;
    using System.Collections.Generic;

    public class User
    {
        public Guid CustomerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public IEnumerable<Account> Accounts { get; set; }
        public decimal TotalBalance { get; set; }
    }
}