using Domain;
using System.Collections.Generic;

namespace Repository
{
    public interface IAddressBookRepository:IRepository<AddressBook>
    {
        IEnumerable<AddressBook> GetAddressBooks();
        //IEnumerable<Contact> GetContacts(int addressBookId);
    }
}
