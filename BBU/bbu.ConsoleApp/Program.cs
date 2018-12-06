using Pluralize.NET;
using System.IO;
using System.Linq;

namespace bbu.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateModels();
        }
        public static void CreateModels()
        {

            var xdContextContent = "";
            var iUnitOfWork = "";
            var unitOfWork1 = "";
            var unitOfWork2 = "";

            var models = new string[] {
                "ProofOfPayment"
                //"Address",
                //"AppUser",
                //"Bank",
                //"BankAccount",
                //"Cemetery",
                //"Credentials",
                //"Deceased",
                //"Doctor",
                //"Funeral",
                //"Employee",
                //"PurchaseItem",
                //"File",
                //"FuneralDocument",
                //"Gender",
                //"HomeAffairsOffice",
                //"HomeAffairsOfficer",
                //"Hospital",
                //"Informant",
                //"Member",
                //"NextOfKin",
                //"Mortuary",
                //"Payment",
                //"PaymentPeriod",
                //"Month",
                //"Year",
                //"Person",
                //"Supplier",
                //"Task",
                //"State",
                //"Setting",
                //"NumberConfiguration",
            };

            foreach (var model in models.OrderBy(x => x))
            {
                using (StreamWriter writer = new StreamWriter(@"D:\_PRSNL\Git\Repo\BBU\BBU\BBU\bbu.Model\" + model + ".cs"))
                {
                    var classContent = @"using System;
                namespace bbu.Model
                {
                    public class " + model + @"
                    {
                        public int Id { get; set; }
                        public string Name { get; set; }
                    }
                }
                ";
                    writer.WriteLine(classContent);
                }
                using (StreamWriter writer = new StreamWriter(@"D:\_PRSNL\Git\Repo\BBU\BBU\BBU\bbu.DAL\Repositories\" + model + "Repository.cs"))
                {
                    var classContent = @"using bbu.DAL.Context;
                using bbu.Interface;
                using bbu.Model;
                using bbu.DAL;
                namespace bbu.DAL.Repositories
                {
                    public class " + model + @"Repository : Repository<" + model + @">, I" + model + @"Repository
                    {
                        public " + model + @"Repository(bbuContext context) : base(context)
                        {
                        }
                        public bbuContext bbuContext
                        {
                            get { return Context as bbuContext; }
                        }
                    }
                }
                ";
                    writer.WriteLine(classContent);
                }
                using (StreamWriter writer = new StreamWriter(@"D:\_PRSNL\Git\Repo\BBU\BBU\BBU\bbu.Interface\I" + model + "Repository .cs"))
                {
                    var classContent = @"using bbu.Model;
                namespace bbu.Interface
                {
                    public interface I" + model + @"Repository : IRepository<" + model + @">
                    {
                    }
                }
                ";
                    writer.WriteLine(classContent);
                }

                xdContextContent += @"public virtual DbSet<" + model + "> " + new Pluralizer().Pluralize(model) + " { get; set; }" + System.Environment.NewLine;
                iUnitOfWork += @"I" + model + "Repository " + new Pluralizer().Pluralize(model) + " { get; }" + System.Environment.NewLine;
                unitOfWork1 += "public I" + model + "Repository " + new Pluralizer().Pluralize(model) + " { get; private set; }" + System.Environment.NewLine;
                unitOfWork2 += new Pluralizer().Pluralize(model) + " = new " + model + "Repository(_context);" + System.Environment.NewLine;
            }

            using (StreamWriter writer = new StreamWriter(@"D:\_PRSNL\Git\Repo\BBU\BBU\BBU\bbu.DAL\bbuContext.cs"))
            {
                xdContextContent = @"using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using bbu.Model;
namespace bbu.DAL.Context
{
    public class bbuContext : DbContext
    {
        public bbuContext() : base(""Name = bbuContext"")
        {
                Configuration.LazyLoadingEnabled = false;
            }
        " + xdContextContent + @"
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}
";
                writer.WriteLine(xdContextContent);
            }
            using (StreamWriter writer = new StreamWriter(@"D:\_PRSNL\Git\Repo\BBU\BBU\BBU\bbu.Interface\IUnitOfWork.cs"))
            {
                iUnitOfWork = @"using System;
namespace bbu.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        " + iUnitOfWork + @"
        int Commit();
    }
}
";
                writer.WriteLine(iUnitOfWork);
            }
            using (StreamWriter writer = new StreamWriter(@"D:\_PRSNL\Git\Repo\BBU\BBU\BBU\bbu.DAL\UnitOfWork.cs"))
            {
                var unitOfWork = @"using bbu.DAL.Context;
using bbu.DAL.Repositories;
using bbu.Interface;
namespace bbu.DAL
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly bbuContext _context;

        public UnitOfWork(bbuContext context)
        {
            _context = context;
            " + unitOfWork2 + @"
        }
        " + unitOfWork1 + @"
        public int Commit()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
";
                writer.WriteLine(unitOfWork);
            }

        }
    }
}
