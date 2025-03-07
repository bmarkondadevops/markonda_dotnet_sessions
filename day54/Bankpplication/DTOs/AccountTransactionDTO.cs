﻿namespace Bankpplication.DTOs
{
    public class AccountTransactionDTO
    {
        public int Id { get; set; }
        public int AccountMasterId { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public string TransactionType { get; set; }
        public DateTime Date { get; set; }

    }
}
