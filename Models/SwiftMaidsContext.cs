using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TermProject_S1.Models;

namespace TermProject_S1.Models
{
    public class SwiftMaidsContext : DbContext
    {
        public SwiftMaidsContext(DbContextOptions<SwiftMaidsContext> options)
            : base(options)
        { }

        public DbSet<Customer> Customer { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                    new Customer
                    {
                        Id = 1,
                        Name = "Jack's Fish Market",
                        Address = "1550 Main St",
                        City = "Traverse City",
                        State = "MI",
                        ZipCode = "49684",
                        PhoneNumber = "231-555-9999",
                        EmailAddress = "jacksfishmarket@hotmail.com",
                        Discount = .10
                    },
                    new Customer
                    {
                        Id = 2,
                        Name = "ProSource Cabinets",
                        Address = "230 Business Park Dr",
                        City = "Traverse City",
                        State = "MI",
                        ZipCode = "49686",
                        PhoneNumber = "231-555-5555",
                    },
                    new Customer
                    {
                        Id = 3,
                        Name = "Up North Flower Shop",
                        Address = "231 8th St",
                        City = "Traverse City",
                        State = "MI",
                        ZipCode = "49684"
                    });
        }
    }
}
