using Domain;

namespace Repository
{
    public class ContactRepository : Repository<Contact>, IContactRepository
    {
        public ContactRepository(ApplicationDbContext context) : base(context)
        {

        }
        public ApplicationDbContext ApplicationDbContext { get { return Context as ApplicationDbContext; } }
    }
}
