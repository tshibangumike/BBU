using System;
using System.Collections.Generic;

namespace bbu.Model
{
    public class Payment
    {
        public Guid Id { get; set; }
        public Guid MemberId { get; set; }
        public Guid PaymentPeriodId { get; set; }
        public Guid DocumentId { get; set; }
        public double Amount { get; set; }
        public DateTime CreatedOn { get; set; }
        public Guid CreatedById { get; set; }
        public int StateId { get; set; }
        public virtual Member Member { get; set; }
        public virtual PaymentPeriod PaymentPeriod { get; set; }
        public virtual AppUser CreatedBy { get; set; }
        public virtual State State { get; set; }
        public ICollection<ProofOfPayment> ProofOfPayments { get; set; }
    }
}
                
