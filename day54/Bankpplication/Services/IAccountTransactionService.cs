using Bankpplication.DTOs;

namespace Bankpplication.Services
{
    public interface IAccountTransactionService
    {

        int HeadCount();
        AccountTransactionDTO CreateAccountTransaction(AccountTransactionDTO accountTransactionDTO);
        bool DeleteAccountTransaction(int id);
        AccountTransactionDTO GetAccountTransactionById(int id);
        List<AccountTransactionDTO> GetAllAccountTransactions();
        AccountTransactionDTO UpdateAccountTransaction(int id, AccountTransactionDTO updatedAccountTransactionDTO);
    }
}