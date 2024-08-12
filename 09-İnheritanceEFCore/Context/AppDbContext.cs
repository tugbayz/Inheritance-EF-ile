using _09_İnheritanceEFCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_İnheritanceEFCore.Context
{
    internal class AppDbContext1:DbContext
    {
        public DbSet<BasePerson_> People { get; set; }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=." +
                ";Initial Catalog=Inheritance;Integrated Security=True;TrustServerCertificate=True");
        }
    }
}
