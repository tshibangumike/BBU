using System;
using System.Collections.Generic;

namespace bbu.Model
{
    public class Supplier
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int StateId { get; set; }
        public Address Address { get; set; }
        public ICollection<Supplier> Suppliers { get; set; }
    }
}
                
