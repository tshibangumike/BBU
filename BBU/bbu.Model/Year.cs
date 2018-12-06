using System.Collections.Generic;

namespace bbu.Model
{
    public class Year
    {
        public int Number { get; set; }
        public ICollection<PaymentPeriod> PaymentPeriods { get; set; }
    }
}
                
