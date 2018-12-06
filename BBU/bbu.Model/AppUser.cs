using System;
using System.Collections;
using System.Collections.Generic;

namespace bbu.Model
{
    public class AppUser
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UniqueName { get; set; }
        public int SateId { get; set; }
        public virtual Credentials Credentials { get; set; }
        public virtual State State { get; set; }
        public ICollection<Funeral> CreatedFunerals { get; set;   }
        public ICollection<Funeral> ModifiedFunerals { get; set; }
        public ICollection<FuneralDocument> CreatedFuneralDocuments { get; set; }
        public ICollection<FuneralDocument> ModifiedFuneralDocuments { get; set; }
        public ICollection<Payment> CreatedPayments { get; set; }
        public ICollection<Person> CreatedPersons { get; set; }
        public ICollection<Person> ModifiedPersons { get; set; }
        public ICollection<ProofOfPayment> CreatedProofOfPayments { get; set; }
        public ICollection<ProofOfPayment> ModifiedProofOfPayments { get; set; }
    }
}
                
