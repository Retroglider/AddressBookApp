using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class User:BaseClass
    {
        [Required]
        public string SystemId { get; set; }
        [Required]
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public virtual ICollection<AddressBook> AddressBooks { get; set; }
    }
}
