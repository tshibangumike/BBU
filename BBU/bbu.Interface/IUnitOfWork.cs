using System;
namespace bbu.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IAddressRepository Addresses { get; }
IAppUserRepository AppUsers { get; }
IBankRepository Banks { get; }
IBankAccountRepository BankAccounts { get; }
ICemeteryRepository Cemeteries { get; }
ICredentialsRepository Credentials { get; }
IDeceasedRepository Deceaseds { get; }
IDoctorRepository Doctors { get; }
IEmployeeRepository Employees { get; }
IFileRepository Files { get; }
IFuneralRepository Funerals { get; }
IFuneralDocumentRepository FuneralDocuments { get; }
IGenderRepository Genders { get; }
IHomeAffairsOfficeRepository HomeAffairsOffices { get; }
IHomeAffairsOfficerRepository HomeAffairsOfficers { get; }
IHospitalRepository Hospitals { get; }
IInformantRepository Informants { get; }
IMemberRepository Members { get; }
IMonthRepository Months { get; }
IMortuaryRepository Mortuaries { get; }
INextOfKinRepository NextOfKins { get; }
INumberConfigurationRepository NumberConfigurations { get; }
IPaymentRepository Payments { get; }
IPaymentPeriodRepository PaymentPeriods { get; }
IPersonRepository People { get; }
IPurchaseItemRepository PurchaseItems { get; }
ISettingRepository Settings { get; }
IStateRepository States { get; }
ISupplierRepository Suppliers { get; }
ITaskRepository Tasks { get; }
IYearRepository Years { get; }

        int Commit();
    }
}

