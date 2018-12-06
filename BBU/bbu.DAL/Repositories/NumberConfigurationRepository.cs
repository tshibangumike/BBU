using bbu.DAL.Context;
                using bbu.Interface;
                using bbu.Model;
                using bbu.DAL;
                namespace bbu.DAL.Repositories
                {
                    public class NumberConfigurationRepository : Repository<NumberConfiguration>, INumberConfigurationRepository
                    {
                        public NumberConfigurationRepository(bbuContext context) : base(context)
                        {
                        }
                        public bbuContext bbuContext
                        {
                            get { return Context as bbuContext; }
                        }
                    }
                }
                
