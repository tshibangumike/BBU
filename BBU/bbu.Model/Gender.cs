using System.Collections;
using System.Collections.Generic;

namespace bbu.Model
{
    public class Gender
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Person> Persons { get; set; }
    }
}
                
