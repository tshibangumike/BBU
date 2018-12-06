using System;
using System.Collections.Generic;

namespace bbu.Model
{
    public class NextOfKin
    {
        public Guid Id { get; set; }
        public string RelationshipToDeceased { get; set; }
        public int StateId { get; set; }
        public virtual State State { get; set; }
        public ICollection<Funeral> Funerals { get; set; }
    }
}
