using HealthCatalystDemoRestAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthCatalystDemoRestAPI.CustomerContext
{
    public class CustomerContext: DbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Data Source=VIVEK;Initial Catalog=Customer;Integrated Security=True");
        //}
        public CustomerContext(DbContextOptions<CustomerContext> options): base(options)
        {

        }
        public DbSet<Customer> Customer { get; set; }
    }
}
