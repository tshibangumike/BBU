using System;
namespace bbu.Model
{
    public class Member
    {
        public Guid PersonId { get; set; }
        public string MemberNumber { get; set; }
        public bool IsMainMember { get; set; }
        public Guid ParentMemberId { get; set; }
        public int StateId { get; set; }
        public virtual Person Person { get; set; }
        public virtual Member ParentMember { get; set; }
        public virtual State State { get; set; }
    }
}
                    
