using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class AddressBook
    {
        public string SystemId { get; set; }
        public string Password { get; set; }
        public List<Contact> Contacts { get; set; }
    }
}
