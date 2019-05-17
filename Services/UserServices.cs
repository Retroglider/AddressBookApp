using Domain;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UserServices
    {
        private readonly UserRepository _userRepository;
        public UserServices(IUserRepository userRepository)
        {

        }
        public User Authenticate(string systemId, string password)
        {
            var user = _userRepository.SingleOrDefault(u => u.SystemId == systemId && u.Password == password);
            return user;
        }
    }
}
