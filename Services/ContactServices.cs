using Domain;
using Repository;
using System;
using System.Collections.Generic;
namespace Services
{
    public class ContactServices:IGenericService<Contact>, IDisposable
    {
        public IUnitOfWork UnitOfWork { get; set; }
        public ContactServices(IUnitOfWork uow)
        {
            UnitOfWork = (UnitOfWork)uow;
        }

        public void Add(Contact entity)
        {
            UnitOfWork.Contacts.Add(entity);
            UnitOfWork.Complete();
        }

        public void AddRange(IEnumerable<Contact> entities)
        {
            UnitOfWork.Contacts.AddRange(entities);
            UnitOfWork.Complete();
        }

        public Contact Get(int id)
        {
            return UnitOfWork.Contacts.Get(id);
        }

        public IEnumerable<Contact> GetAll()
        {
            return UnitOfWork.Contacts.GetAll();
        }

        public void Remove(Contact entity)
        {
            UnitOfWork.Contacts.Remove(entity);
            UnitOfWork.Complete();
        }
        public void Dispose()
        {
            UnitOfWork.Dispose();
        }
    }
}
