using System;

namespace Repository
{
    interface IUnitOfWork:IDisposable
    {
        IAddressBookRepository AddressBooks { get; }
        ContactRepository Contacts { get; }
        int Complete();
    }
}
