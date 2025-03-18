using BankApplicationV2.DTOs;
using System.Collections.Generic;

namespace BankApplicationV2.Services
{
    public interface ITransactionService
    {
        void PerformTransaction(AccountTransactionDTO transactionDTO);
        IEnumerable<AccountTransactionDTO> GetTransactionHistory(int accountMasterId);

        void UpdateAccountBalance(int accountId, decimal amount, string transactionType);

        //void ReverseTransactionEffect(int transactionId);

        //void UpdateAmount(AccountTransactionDTO transactionDTO);

    }
}
