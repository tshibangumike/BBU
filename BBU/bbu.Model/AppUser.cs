using System;
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
    }
}
                
