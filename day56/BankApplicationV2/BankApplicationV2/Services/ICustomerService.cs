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
        public AccountMaster AuthenticateUser(string email, string password);
        AccountMaster GetAccountByEmail(string email);

         

        //IEnumerable<AccountMaster> login(string username,string password);
        //IEnumerable<AccountMaster> GetAccountByName(string name);

        //Transaction
        //IEnumerable<AccountTransaction> GetTransactions(int accountId);
        //void CreateTransaction(AccountTransactionDTO transaction);
        //void UpdateTransaction(AccountTransactionDTO transaction);

        //void DeleteTransaction(int id);

    }
}