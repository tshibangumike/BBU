using bbu.DAL.Context;
                using bbu.Interface;
                using bbu.Model;
                using bbu.DAL;
                namespace bbu.DAL.Repositories
                {
                    public class YearRepository : Repository<Year>, IYearRepository
                    {
                        public YearRepository(bbuContext context) : base(context)
                        {
                        }
                        public bbuContext bbuContext
                        {
                            get { return Context as bbuContext; }
                        }
                    }
                }
                
