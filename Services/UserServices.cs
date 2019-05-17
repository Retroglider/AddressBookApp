using Domain;
using Repository;
using System;

namespace Services
{
    public class UserServices:GenericService<User>
    {
        
        public UserServices(IRepository<User> userRepository)
        {
            this.Repository = userRepository;
        }
        public User Authenticate(string systemId, string password)
        {
            var user = Repository.SingleOrDefault(u => u.SystemId == systemId && u.Password == password);

            
            if (user == null)
                throw new Exception("System ID/password combination invalid.");
            return user;
        }
    }
}
