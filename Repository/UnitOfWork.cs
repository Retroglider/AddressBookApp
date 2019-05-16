using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Users = new UserRepository(_context);
            AddressBooks = new AddressBookRepository(_context);
            Contacts = new ContactRepository(_context);
        }
        public IUserRepository Users { get; private set; }
        public IAddressBookRepository AddressBooks { get; private set; }
        public IContactRepository Contacts { get; private set; }

        public void Complete()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        int IUnitOfWork.Complete()
        {
            return _context.SaveChanges();
        }
    }
}
