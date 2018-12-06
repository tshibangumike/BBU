using System;
namespace bbu.Model
{
    public class Address
    {
        public Guid Id { get; set; }
        public string FullAddress { get; set; }
        public string UnitNnumber { get; set; }
        public string StreetNumber { get; set; }
        public string StreetAddress { get; set; }
        public string SubLocality { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public int StateId { get; set; }
        public virtual State State { get; set; }
    }
}
                
