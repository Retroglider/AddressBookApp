using Repository;
namespace Services
{
    public class ContactServices
    {
        private readonly IContactRepository _contactRepository;
        public ContactServices(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }
    }
}
