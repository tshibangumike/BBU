using System;
namespace bbu.Model
{
    public class ProofOfPayment
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid PaymentId { get; set; }
        public string CreatedById { get; set; }
        public string CreatedOn { get; set; }
        public string ModifiedById { get; set; }
        public string ModifiedOn { get; set; }
        public int StateId { get; set; }
        public virtual Payment Payment { get; set; }
        public virtual AppUser CreatedBy { get; set; }
        public virtual AppUser ModifiedBy { get; set; }
        public virtual State State { get; set; }
    }
}
