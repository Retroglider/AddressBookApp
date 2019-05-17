using Domain;
using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Configuration;
using System;

namespace Repository
{
    public class ApplicationDbContext:DbContext, IContext
    {
        public ApplicationDbContext()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //IConfigurationRoot configuration = new ConfigurationBuilder()
            //    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            //    .AddJsonFile("appsettings.json")
            //    .Build();
            //optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            optionsBuilder.UseSqlServer("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=AddressBookApp;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        // Entities
        public DbSet<User> Users { get; set; }
        public DbSet<AddressBook> AddressBooks { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}
