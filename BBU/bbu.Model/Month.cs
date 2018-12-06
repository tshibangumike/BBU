using System.Collections.Generic;

namespace bbu.Model
{
    public class Month
    {
        public string Name { get; set; }
        public ICollection<PaymentPeriod> PaymentPeriods { get; set; }
    }
}
                
