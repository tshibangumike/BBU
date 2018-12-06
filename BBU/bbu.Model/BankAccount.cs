using System;
namespace bbu.Model
{
    public class BankAccount
    {
        public Guid Id { get; set; }
        public string AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public string BranchCode { get; set; }
        public string BranchName { get; set; }
        public string Reference { get; set; }
        public int BankId { get; set; }
        public int StateId { get; set; }
        public virtual Bank Bank { get; set; }
        public virtual State State { get; set; }
    }
}
                
