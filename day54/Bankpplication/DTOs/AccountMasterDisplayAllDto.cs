using Bankpplication.Domain;

namespace Bankpplication.DTOs
{
    //model to the view
    public class AccountMasterDisplayAllDto
    {

       public int Count { get; set; }
       public string HeaderTitle { get; set; }

        public List<AccountMaster> AccountMaster { get; set; }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
