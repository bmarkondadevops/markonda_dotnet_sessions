
using BankApplicationV2.Domain;

namespace BankApplicationV2.DTOs
{
    public class AccountMasterEditDto
    {

        public int Count { get; set; }
        public string HeaderTitle { get; set; }      

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }
        public string Email { get; set; }
        
    }
}