using bbu.DAL.Context;
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
            Addresses = new AddressRepository(_context);
AppUsers = new AppUserRepository(_context);
Banks = new BankRepository(_context);
BankAccounts = new BankAccountRepository(_context);
Cemeteries = new CemeteryRepository(_context);
Credentials = new CredentialsRepository(_context);
Deceaseds = new DeceasedRepository(_context);
Doctors = new DoctorRepository(_context);
Employees = new EmployeeRepository(_context);
Files = new FileRepository(_context);
Funerals = new FuneralRepository(_context);
FuneralDocuments = new FuneralDocumentRepository(_context);
Genders = new GenderRepository(_context);
HomeAffairsOffices = new HomeAffairsOfficeRepository(_context);
HomeAffairsOfficers = new HomeAffairsOfficerRepository(_context);
Hospitals = new HospitalRepository(_context);
Informants = new InformantRepository(_context);
Members = new MemberRepository(_context);
Months = new MonthRepository(_context);
Mortuaries = new MortuaryRepository(_context);
NextOfKins = new NextOfKinRepository(_context);
NumberConfigurations = new NumberConfigurationRepository(_context);
Payments = new PaymentRepository(_context);
PaymentPeriods = new PaymentPeriodRepository(_context);
People = new PersonRepository(_context);
PurchaseItems = new PurchaseItemRepository(_context);
Settings = new SettingRepository(_context);
States = new StateRepository(_context);
Suppliers = new SupplierRepository(_context);
Tasks = new TaskRepository(_context);
Years = new YearRepository(_context);

        }
        public IAddressRepository Addresses { get; private set; }
public IAppUserRepository AppUsers { get; private set; }
public IBankRepository Banks { get; private set; }
public IBankAccountRepository BankAccounts { get; private set; }
public ICemeteryRepository Cemeteries { get; private set; }
public ICredentialsRepository Credentials { get; private set; }
public IDeceasedRepository Deceaseds { get; private set; }
public IDoctorRepository Doctors { get; private set; }
public IEmployeeRepository Employees { get; private set; }
public IFileRepository Files { get; private set; }
public IFuneralRepository Funerals { get; private set; }
public IFuneralDocumentRepository FuneralDocuments { get; private set; }
public IGenderRepository Genders { get; private set; }
public IHomeAffairsOfficeRepository HomeAffairsOffices { get; private set; }
public IHomeAffairsOfficerRepository HomeAffairsOfficers { get; private set; }
public IHospitalRepository Hospitals { get; private set; }
public IInformantRepository Informants { get; private set; }
public IMemberRepository Members { get; private set; }
public IMonthRepository Months { get; private set; }
public IMortuaryRepository Mortuaries { get; private set; }
public INextOfKinRepository NextOfKins { get; private set; }
public INumberConfigurationRepository NumberConfigurations { get; private set; }
public IPaymentRepository Payments { get; private set; }
public IPaymentPeriodRepository PaymentPeriods { get; private set; }
public IPersonRepository People { get; private set; }
public IPurchaseItemRepository PurchaseItems { get; private set; }
public ISettingRepository Settings { get; private set; }
public IStateRepository States { get; private set; }
public ISupplierRepository Suppliers { get; private set; }
public ITaskRepository Tasks { get; private set; }
public IYearRepository Years { get; private set; }

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

