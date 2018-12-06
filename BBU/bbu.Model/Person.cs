using System;
namespace bbu.Model
{
    public class Person
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string MiddleName { get; set; }
        public string SaIdNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int GenderId { get; set; }
        public string CellPhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public DateTime CreatedOn { get; set; }
        public Guid CreatedById { get; set; }
        public DateTime ModifiedOn { get; set; }
        public Guid ModifiedById { get; set; }
        public int StateId { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual Address Address { get; set; }
        public virtual AppUser CreatedBy { get; set; }
        public virtual AppUser ModifiedBy { get; set; }
        public virtual State State { get; set; }
    }
}
                
