using Microsoft.EntityFrameworkCore;
using SimpleEFProject.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEFProject.Data
{
    public class RrdDbcontext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=rrdEf;Integrated Security=True;TrustServerCertificate=True;MultipleActiveResultSets=true");
        }

    }
}
