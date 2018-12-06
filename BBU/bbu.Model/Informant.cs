using System;
using System.Collections.Generic;

namespace bbu.Model
{
    public class Informant
    {
        public Guid PersonId { get; set; }
        public string RelationshipToDeceased { get; set; }
        public int StateId { get; set; }
        public virtual Person Person { get; set; }
        public virtual State State { get; set; }
        public ICollection<Funeral> Funerals { get; set; }
    }
}
                
