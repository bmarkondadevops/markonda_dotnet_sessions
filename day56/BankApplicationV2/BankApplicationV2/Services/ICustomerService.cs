using System.Collections.Generic;
using BankApplicationV2.Domain;
using BankApplicationV2.DTOs;

namespace BankApplicationV2.Services
{
    public interface ICustomerService
    {
        void Add(AccountMaster accountMaster);
        IEnumerable<AccountMaster> Get();
        AccountMaster GetById(int id);
        int HeadCount();
        void Remove(int id);
        void Update(AccountMaster accountmaster);
        void login(AccountMaster accountMaster);

        //Transaction
        IEnumerable<AccountTransaction> GetTransactions(int accountId);
        void CreateTransaction(AccountTransactionDTO transaction);
        void UpdateTransaction(AccountTransactionDTO transaction);

        //void DeleteTransaction(int id);

    }
}