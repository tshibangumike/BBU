using bbu.DAL.Context;
using bbu.DAL.Repositories;
using bbu.Interface;
namespace bbu.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly bbuContext _context;

        public UnitOfWork(bbuContext context)
        {
            _context = context;
            Addresses = new AddressRepository(_context);
            AppUsers = new AppUserRepository(_context);
            Cemeteries = new CemeteryRepository(_context);
            Deceaseds = new DeceasedRepository(_context);
            Doctors = new DoctorRepository(_context);
            Funerals = new FuneralRepository(_context);
            Genders = new GenderRepository(_context);
            HomeAffairsOfficers = new HomeAffairsOfficerRepository(_context);
            Hospitals = new HospitalRepository(_context);
            Informants = new InformantRepository(_context);
            NextOfKins = new NextOfKinRepository(_context);

        }
        public IAddressRepository Addresses { get; private set; }
        public IAppUserRepository AppUsers { get; private set; }
        public ICemeteryRepository Cemeteries { get; private set; }
        public IDeceasedRepository Deceaseds { get; private set; }
        public IDoctorRepository Doctors { get; private set; }
        public IFuneralRepository Funerals { get; private set; }
        public IGenderRepository Genders { get; private set; }
        public IHomeAffairsOfficerRepository HomeAffairsOfficers { get; private set; }
        public IHospitalRepository Hospitals { get; private set; }
        public IInformantRepository Informants { get; private set; }
        public INextOfKinRepository NextOfKins { get; private set; }

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

