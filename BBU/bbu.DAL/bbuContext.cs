using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using bbu.Model;
namespace bbu.DAL.Context
{
    public class bbuContext : DbContext
    {
        public bbuContext() : base("Name = bbuContext")
        {
                Configuration.LazyLoadingEnabled = false;
            }
        public virtual DbSet<Address> Addresses { get; set; }
public virtual DbSet<AppUser> AppUsers { get; set; }
public virtual DbSet<Bank> Banks { get; set; }
public virtual DbSet<BankAccount> BankAccounts { get; set; }
public virtual DbSet<Cemetery> Cemeteries { get; set; }
public virtual DbSet<Credentials> Credentials { get; set; }
public virtual DbSet<Deceased> Deceaseds { get; set; }
public virtual DbSet<Doctor> Doctors { get; set; }
public virtual DbSet<Employee> Employees { get; set; }
public virtual DbSet<File> Files { get; set; }
public virtual DbSet<Funeral> Funerals { get; set; }
public virtual DbSet<FuneralDocument> FuneralDocuments { get; set; }
public virtual DbSet<Gender> Genders { get; set; }
public virtual DbSet<HomeAffairsOffice> HomeAffairsOffices { get; set; }
public virtual DbSet<HomeAffairsOfficer> HomeAffairsOfficers { get; set; }
public virtual DbSet<Hospital> Hospitals { get; set; }
public virtual DbSet<Informant> Informants { get; set; }
public virtual DbSet<Member> Members { get; set; }
public virtual DbSet<Month> Months { get; set; }
public virtual DbSet<Mortuary> Mortuaries { get; set; }
public virtual DbSet<NextOfKin> NextOfKins { get; set; }
public virtual DbSet<NumberConfiguration> NumberConfigurations { get; set; }
public virtual DbSet<Payment> Payments { get; set; }
public virtual DbSet<PaymentPeriod> PaymentPeriods { get; set; }
public virtual DbSet<Person> People { get; set; }
public virtual DbSet<PurchaseItem> PurchaseItems { get; set; }
public virtual DbSet<Setting> Settings { get; set; }
public virtual DbSet<State> States { get; set; }
public virtual DbSet<Supplier> Suppliers { get; set; }
public virtual DbSet<Task> Tasks { get; set; }
public virtual DbSet<Year> Years { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}

