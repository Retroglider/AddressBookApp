using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationMvc.Models
{
    public class ContactListViewModel
    {
        public string AddressBookName { get; set; }
        public int AddressBookId { get; set; }
        public IEnumerable<ContactDetailViewModel> Contacts { get; set; }
    }
}
