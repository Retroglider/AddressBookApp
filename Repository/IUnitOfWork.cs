﻿using System;

namespace Repository
{
    interface IUnitOfWork:IDisposable
    {
        IUserRepository Users { get; }
        IAddressBookRepository AddressBooks { get; }
        IContactRepository Contacts { get; }
        int Complete();
    }
}
