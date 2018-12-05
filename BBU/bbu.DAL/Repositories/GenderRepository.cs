using bbu.DAL.Context;
using bbu.Interface;
using bbu.Model;
namespace bbu.DAL.Repositories
{
    public class GenderRepository : Repository<Gender>, IGenderRepository
    {
        public GenderRepository(bbuContext context) : base(context)
        {
        }
        public bbuContext bbuContext
        {
            get { return Context as bbuContext; }
        }
    }
}
                
