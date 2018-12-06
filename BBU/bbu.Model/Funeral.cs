using System;
using System.Collections.Generic;

namespace bbu.Model
{
    public class Funeral
    {
        public Guid Id { get; set; }
        public string FuneralNumber { get; set; }
        public string GraveNumber { get; set; }
        public DateTime BurialDate { get; set; }
        public Guid DeceasedId { get; set; }
        public Guid InformantId { get; set; }
        public Guid NextOfKinId { get; set; }
        public Guid DoctorId { get; set; }
        public Guid HomeAffairsOfficerId { get; set; }
        public Guid MortuaryId { get; set; }
        public Guid CemeteryId { get; set; }
        public Guid MemberId { get; set; }
        public DateTime CreatedOn { get; set; }
        public Guid CreatedById { get; set; }
        public DateTime ModifiedOn { get; set; }
        public Guid ModifiedById { get; set; }
        public int StateId { get; set; }
        public virtual Deceased Deceased { get; set; }
        public virtual Informant Informant { get; set; }
        public virtual NextOfKin NextOfKin { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual HomeAffairsOfficer HomeAffairsOfficer { get; set; }
        public virtual Mortuary Mortuary { get; set; }
        public virtual Cemetery Cemetery { get; set; }
        public virtual AppUser CreatedBy { get; set; }
        public virtual AppUser ModifiedBy { get; set; }
        public virtual State State { get; set; }
        public ICollection<FuneralDocument> FuneralDocuments { get; set; }
        public ICollection<PurchaseItem> PurchaseItems { get; set; }
        
    }
}
                
