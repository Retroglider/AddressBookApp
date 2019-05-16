using Domain;

namespace Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context)
        {

        }
        public ApplicationDbContext ApplicationDbContext { get { return Context as ApplicationDbContext; } }
    }
}
