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
        public virtual DbSet<Cemetery> Cemeteries { get; set; }
        public virtual DbSet<Deceased> Deceaseds { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Funeral> Funerals { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<HomeAffairsOfficer> HomeAffairsOfficers { get; set; }
        public virtual DbSet<Hospital> Hospitals { get; set; }
        public virtual DbSet<Informant> Informants { get; set; }
        public virtual DbSet<NextOfKin> NextOfKins { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}

