using Bankpplication.Domain;


namespace Bankpplication.Services
{
    public interface ICustomerService
    {
        void Add(AccountMaster am);
        AccountMaster GetById(int id);
        int HeadCount();
        void Remove(int id);
        void Update(AccountMaster customer);
        public IEnumerable<AccountMaster> Get();

    }
}