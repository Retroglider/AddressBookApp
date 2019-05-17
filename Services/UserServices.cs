using Domain;
using Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services
{
    public class UserServices : IGenericService<User>
    {
        public IUnitOfWork UnitOfWork { get;  set; }
        public UserServices(IUnitOfWork uow)
        {
            //this.Repository = userRepository;
            UnitOfWork = (UnitOfWork)uow;
        }

        public void Add(User entity)
        {
            UnitOfWork.Users.Add(entity);
            UnitOfWork.Complete();
        }

        public void AddRange(IEnumerable<User> entities)
        {
            UnitOfWork.Users.AddRange(entities);
            UnitOfWork.Complete();
        }

        public User Get(int id)
        {
            return UnitOfWork.Users.Get(id);
        }

        public IEnumerable<User> GetAll()
        {
            return UnitOfWork.Users.GetAll();
        }

        public void Remove(User entity)
        {
            UnitOfWork.Users.Remove(entity);
            UnitOfWork.Complete();
        }
        public User Authenticate(string systemId, string password)
        {
            using (var uow = UnitOfWork)
            {
                var user = uow.Users.SingleOrDefault(u => u.SystemId == systemId && u.Password == password);

                if (user == null)
                    throw new Exception("System ID/password combination invalid.");
                return user;
            }
        }
        //public void Dispose()
        //{
        //    UnitOfWork.Dispose();
        //}
    }
}
