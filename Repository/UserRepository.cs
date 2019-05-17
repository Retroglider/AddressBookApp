using Domain;

namespace Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(IContext context) : base(context)
        {

        }
        public IContext ApplicationDbContext { get { return Context as IContext; } }
    }
}
