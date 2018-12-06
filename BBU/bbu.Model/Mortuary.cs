using System;
using System.Collections.Generic;

namespace bbu.Model
{
    public class Mortuary
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int StateId { get; set; }
        public virtual Address Address { get; set; }
        public virtual State State { get; set; }
        public ICollection<Funeral> Funerals { get; set; }
    }
}
                
