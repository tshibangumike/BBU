using bbu.DAL.Context;
                using bbu.Interface;
                using bbu.Model;
                using bbu.DAL;
                namespace bbu.DAL.Repositories
                {
                    public class FileRepository : Repository<File>, IFileRepository
                    {
                        public FileRepository(bbuContext context) : base(context)
                        {
                        }
                        public bbuContext bbuContext
                        {
                            get { return Context as bbuContext; }
                        }
                    }
                }
                
