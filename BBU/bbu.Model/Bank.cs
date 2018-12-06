using System.Collections.Generic;
namespace bbu.Model
{
    public class Bank
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StateId { get; set; }
        public virtual State State { get; set; }
        public ICollection<BankAccount> BankAccounts { get; set; }
    }
}
                
