using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using Hillerød_Sejklub.Repo;

namespace Hillerød_Sejklub.Pages
{
    public class MembersModel : PageModel
    {
        // Repository-objekt til at hente medlemmer
        private MemberRepository _repo = new MemberRepository();

        // Liste med medlemmer, som bruges i view
        public List<Member> MembersList { get; private set; }

        // Kaldes når siden indlæses 
        public void OnGet()
        {
            MembersList = _repo.GetAll();
        }

        // Din nested Member-klasse
        public class Member
        {
            private int _memberId;
            private string _name;
            private string _email;
            private string _phone;
            private bool _isActive;

            public int MemberId { get { return _memberId; } private set { _memberId = value; } }
            public string Name { get { return _name; } set { _name = value; } }
            public string Email { get { return _email; } set { _email = value; } }
            public string Phone { get { return _phone; } set { _phone = value; } }
            public bool IsActive { get { return _isActive; } set { _isActive = value; } }

            public Member(int memberId, string name, string email, string phone, bool isActive)
            {
                _memberId = memberId;
                _name = name;
                _email = email;
                _phone = phone;
                _isActive = isActive;
            }
        }
    }
}

