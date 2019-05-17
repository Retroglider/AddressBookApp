using Domain;
using Repository;
using System;
using System.Collections.Generic;

namespace Services
{
    public class AddressBookServices:IGenericService<AddressBook>, IDisposable
    {
        public IUnitOfWork UnitOfWork { get; set; }
        public AddressBookServices(IUnitOfWork uow)
        {
            UnitOfWork = (UnitOfWork)uow;
        }


        public void Add(AddressBook entity)
        {
            UnitOfWork.AddressBooks.Add(entity);
            UnitOfWork.Complete();
        }

        public void AddRange(IEnumerable<AddressBook> entities)
        {
            UnitOfWork.AddressBooks.AddRange(entities);
            UnitOfWork.Complete();
        }

        public AddressBook Get(int id)
        {
            return UnitOfWork.AddressBooks.Get(id);
        }

        public IEnumerable<AddressBook> GetAll()
        {
            return UnitOfWork.AddressBooks.GetAll();
        }

        public void Remove(AddressBook entity)
        {
            UnitOfWork.AddressBooks.Remove(entity);
            UnitOfWork.Complete();
        }
        public void Dispose()
        {
            UnitOfWork.Dispose();
        }
    }
}
