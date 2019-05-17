using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IContactContract
    {
        int AddressBookId { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string StreetAddress { get; set; }
        string City { get; set; }
        string State { get; set; }
        string ZipCode { get; set; }
        string Phone { get; set; }
        string Email { get; set; }
    }
}
