using System;
namespace bbu.Model
{
    public class Doctor
    {
        public Guid PersonId { get; set; }
        public string PracticeNumber { get; set; }
        public Guid HospitalId { get; set; }
        public int StateId { get; set; }
        public virtual Person Person { get; set; }
        public virtual Hospital Hospital { get; set; }
        public virtual State State { get; set; }
    }
}
                
