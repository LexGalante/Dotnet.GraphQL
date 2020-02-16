using Dotnet.GraphQL.Api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotnet.GraphQL.Api.Contexts
{
    public class ApiDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public ApiDbContext(DbContextOptions options) : base(options) 
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasKey(x => x.Id);
        }
    }
}
