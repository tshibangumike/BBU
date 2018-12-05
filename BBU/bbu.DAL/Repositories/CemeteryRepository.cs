using bbu.DAL.Context;
using bbu.Interface;
using bbu.Model;
namespace bbu.DAL.Repositories
{
    public class CemeteryRepository : Repository<Cemetery>, ICemeteryRepository
    {
        public CemeteryRepository(bbuContext context) : base(context)
        {
        }
        public bbuContext bbuContext
        {
            get { return Context as bbuContext; }
        }
    }
}
                
