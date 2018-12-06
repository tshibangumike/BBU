using System;
namespace bbu.Model
{
    public class FuneralDocument
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid FuneralId { get; set; }
        public string CreatedById { get; set; }
        public string CreatedOn { get; set; }
        public string ModifiedById { get; set; }
        public string ModifiedOn { get; set; }
        public virtual Funeral Funeral { get; set; }
        public virtual AppUser CreatedBy { get; set; }
        public virtual AppUser ModifiedBy { get; set; }
        public virtual State State { get; set; }
    }
}
                
