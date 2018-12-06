using System.Collections.Generic;

namespace bbu.Model
{
    public class State
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Address> Addresses { get; set; }
        public ICollection<AppUser> AppUsers { get; set; }
        public ICollection<Bank> Banks { get; set; }
        public ICollection<BankAccount> BankAccounts { get; set; }
        public ICollection<Cemetery> Cemeteries { get; set; }
        public ICollection<Credentials> Credentials { get; set; }
        public ICollection<Deceased> Deceaseds { get; set; }
        public ICollection<Doctor> Doctors { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public ICollection<Funeral> Funerals { get; set; }
        public ICollection<FuneralDocument> FuneralDocuments { get; set; }
        public ICollection<HomeAffairsOffice> HomeAffairsOffices { get; set; }
        public ICollection<HomeAffairsOfficer> HomeAffairsOfficers { get; set; }
        public ICollection<Hospital> Hospitals { get; set; }
        public ICollection<Informant> Informants { get; set; }
        public ICollection<Member> Members { get; set; }
        public ICollection<Mortuary> Mortuaries { get; set; }
        public ICollection<NextOfKin> NextOfKins { get; set; }
        public ICollection<Payment> Payments { get; set; }
        public ICollection<Person> Persons { get; set; }
        public ICollection<ProofOfPayment> ProofOfPayments { get; set; }
        public ICollection<PurchaseItem> PurchaseItems { get; set; }
        public ICollection<Hospital> Hospitals { get; set; }
    }
}
                
