using System;
namespace bbu.Model
{
    public class HomeAffairsOfficer
    {
        public Guid PersonId { get; set; }
        public Guid HomeAffairsOfficeId { get; set; }
        public Guid AddressId { get; set; }
        public int StateId { get; set; }
        public virtual Person Person { get; set; }
        public virtual HomeAffairsOffice HomeAffairsOffice { get; set; }
        public virtual Address Address { get; set; }
        public virtual State State { get; set; }
    }
}
                
