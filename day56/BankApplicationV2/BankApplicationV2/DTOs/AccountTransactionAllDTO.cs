using System;
using BankApplicationV2.Domain;
using System.Collections.Generic;

namespace BankApplicationV2.DTOs
{
    public class AccountTransactionAllDTO
    {

        public int Count { get; set; }
        public string HeaderTitle { get; set; }
        public List<AccountTransaction> AccountTransactions { get; set; }
        public int Id { get; set; }

        public int AccountMasterId { get; set; }

        public string Name { get; set; }

        public decimal Amount { get; set; }

        public string TransactionType { get; set; }

        public DateTime Date { get; set; }
    }
}
