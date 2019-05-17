using Domain;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public interface IContext 
    {
        int SaveChanges();
        DbSet<User> Users { get; set; }
        DbSet<AddressBook> AddressBooks { get; set; }
        DbSet<Contact> Contacts { get; set; }
    }
}
