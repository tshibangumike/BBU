using System;
namespace bbu.Model
{
    public class Credentials
    {
        public Guid AppUserId { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public DateTime LastLogin { get; set; }
        public int StateId { get; set; }
        public virtual AppUser AppUser { get; set; }
        public virtual State State { get; set; }
    }
}
                
