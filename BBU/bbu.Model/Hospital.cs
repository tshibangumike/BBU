using System;
using System.Collections.Generic;

namespace bbu.Model
{
    public class Hospital
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StateId { get; set; }
        public virtual Address Address { get; set; }
        public virtual State State { get; set; }
        public ICollection<Doctor> Doctors { get; set; }
    }
}
                
