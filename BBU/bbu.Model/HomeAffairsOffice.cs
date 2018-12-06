using System;
using System.Collections;
using System.Collections.Generic;

namespace bbu.Model
{
    public class HomeAffairsOffice
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<HomeAffairsOfficer> HomeAffairsOfficers { get; set; }
    }
}
                
