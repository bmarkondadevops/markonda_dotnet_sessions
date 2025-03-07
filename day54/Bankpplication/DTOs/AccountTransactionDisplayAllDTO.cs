using Bankpplication.Domain;

namespace Bankpplication.DTOs
{
    public class AccountTransactionDisplayAllDTO
    {

        public int Count { get; set; }
        public string HeaderTitle { get; set; }
        public List<AccountTransaction> AccountTransaction { get; set; }
        public int Id { get; set; }
        public int AccountMasterId { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public string TransactionType { get; set; }
        public DateTime Date { get; set; }
    }
}
