using System.ComponentModel.DataAnnotations;

namespace MVCRepositoryApp.Domain
{
    public class Calc
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
    public class Organization
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
