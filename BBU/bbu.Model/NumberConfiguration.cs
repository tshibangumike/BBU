using System;
namespace bbu.Model
{
    public class NumberConfiguration
    {
        public Guid Id { get; set; }
        public string EntityName { get; set; }
        public int Length { get; set; }
        public int IncrementBy { get; set; }
        public int NextNumber { get; set; }
        public string Prefix { get; set; }
        public string Suffix { get; set; }
        public int StateId { get; set; }
        public virtual State State { get; set; }
    }
}
                
