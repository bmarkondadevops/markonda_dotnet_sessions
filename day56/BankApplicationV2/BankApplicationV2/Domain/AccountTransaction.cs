﻿namespace BankApplicationV2.Domain
{
    public class AccountTransaction
    {
        public int Id { get; set; }
        public int AccountMasterId { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public string Type { get; set; }
        public string Date { get; set; }
    }
}
