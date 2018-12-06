using System;
namespace bbu.Model
{
    public class PurchaseItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public Guid FuneralId { get; set; }
        public Guid SupplierId { get; set; }
        public int StateId { get; set; }
        public virtual Funeral Funeral { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual State State { get; set; }
    }
}
                
