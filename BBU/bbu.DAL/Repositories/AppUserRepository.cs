using bbu.DAL.Context;
using bbu.Interface;
using bbu.Model;
namespace bbu.DAL.Repositories
{
    public class AppUserRepository : Repository<AppUser>, IAppUserRepository
    {
        public AppUserRepository(bbuContext context) : base(context)
        {
        }
        public bbuContext bbuContext
        {
            get { return Context as bbuContext; }
        }
    }
}
                
