using bbu.DAL.Context;
using bbu.Interface;
using bbu.Model;
namespace bbu.DAL.Repositories
{
    public class HomeAffairsOfficerRepository : Repository<HomeAffairsOfficer>, IHomeAffairsOfficerRepository
    {
        public HomeAffairsOfficerRepository(bbuContext context) : base(context)
        {
        }
        public bbuContext bbuContext
        {
            get { return Context as bbuContext; }
        }
    }
}
                
