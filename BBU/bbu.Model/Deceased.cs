using System;
namespace bbu.Model
{
    public class Deceased
    {
        public Guid PersonId { get; set; }
        public DateTime DateOfDeath { get; set; }
        public string PlaceOfDeath { get; set; }
        public string PlaceOfBodyRetrieval { get; set; }
        public string CauseOfDeath { get; set; }
        public int StateId { get; set; }
        public virtual  Funeral Funeral { get; set; }
        public virtual Person Person { get; }
        public virtual State State { get; set; }
    }
}
                
