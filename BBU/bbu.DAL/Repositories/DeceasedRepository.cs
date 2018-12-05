using bbu.DAL.Context;
using bbu.Interface;
using bbu.Model;
namespace bbu.DAL.Repositories
{
    public class DeceasedRepository : Repository<Deceased>, IDeceasedRepository
    {
        public DeceasedRepository(bbuContext context) : base(context)
        {
        }
        public bbuContext bbuContext
        {
            get { return Context as bbuContext; }
        }
    }
}
                
