using System;
namespace bbu.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IAddressRepository Addresses { get; }
        IAppUserRepository AppUsers { get; }
        ICemeteryRepository Cemeteries { get; }
        IDeceasedRepository Deceaseds { get; }
        IDoctorRepository Doctors { get; }
        IFuneralRepository Funerals { get; }
        IGenderRepository Genders { get; }
        IHomeAffairsOfficerRepository HomeAffairsOfficers { get; }
        IHospitalRepository Hospitals { get; }
        IInformantRepository Informants { get; }
        INextOfKinRepository NextOfKins { get; }

        int Commit();
    }
}

