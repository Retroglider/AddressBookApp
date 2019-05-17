using Repository;

namespace Services
{
    public class AddressBookServices
    {
        private readonly IAddressBookRepository _addressBookRepository;
        public AddressBookServices(IAddressBookRepository addressBookRepository)
        {
            _addressBookRepository = addressBookRepository;
        }

        
    }
}
