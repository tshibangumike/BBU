using bbu.DAL.Context;
using bbu.Interface;
using bbu.Model;
namespace bbu.DAL.Repositories
{
    public class InformantRepository : Repository<Informant>, IInformantRepository
    {
        public InformantRepository(bbuContext context) : base(context)
        {
        }
        public bbuContext bbuContext
        {
            get { return Context as bbuContext; }
        }
    }
}
                
