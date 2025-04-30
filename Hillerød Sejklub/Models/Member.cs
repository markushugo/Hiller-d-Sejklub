namespace Hillerød_Sejklub.Models
{
    // Medlemsmodel
    public class Member
    {
        public int MemberId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool IsActive { get; set; }

        public Member(int memberid, string name, string email, string phone, bool isActive)
        {
            MemberId = memberid;
            Name = name;
            Email = email;
            Phone = phone;
            IsActive = isActive;
        }
    }
}

