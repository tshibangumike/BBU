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
    }
}
                
