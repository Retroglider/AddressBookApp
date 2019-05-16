using Domain;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class AddressBookRepository : Repository<AddressBook>, IAddressBookRepository
    {
        public AddressBookRepository(ApplicationDbContext context) : base(context)
        {

        }
        public IEnumerable<AddressBook> GetAddressBooks()
        {
            var result = Context.AddressBooks.OrderBy(a => a.Name);
            return null;
        }
        public ApplicationDbContext ApplicationDbContext { get { return Context as ApplicationDbContext; } }
    }
}
