using System;
namespace bbu.Model
{
    public class Supplier
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid AddressId { get; set; }
        public int StateId { get; set; }
    }
}
                
