using System.Collections.Generic;

namespace Domain
{
    public class AddressBook
    {
        public string SystemId { get; set; }
        public string Password { get; set; }
        public List<Contact> Contacts { get; set; }
    }
}
