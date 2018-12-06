using System;
namespace bbu.Model
{
    public class PaymentPeriod
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string MonthName { get; set; }
        public int YearNumber { get; set; }
        public virtual Month Month { get; set; }
        public virtual Year Year { get; set; }
    }
}
                
