using System.Collections.Generic;

namespace Domain
{
    public class AddressBook:BaseClass
    {


        public string Name { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
    }
}
