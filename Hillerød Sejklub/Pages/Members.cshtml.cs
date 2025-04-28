using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;   

namespace Hillerød_Sejklub.Pages
{
    // PageModel class for the Members page
    public class MembersModel : PageModel
    {
        // Inner/public class representing a member 
        public class Member
        {
            //private fields for our member object
            private int _memberId;
            private string _name;
            private string _email;
            private string _phone;
            private bool _isActive;

            // Public properties for our member object
            public int MemberId
            {
                get { return _memberId; }
                set { _memberId = value; }
            }
            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }
            public string Email
            {
                get { return _email; }
                set { _email = value; }
            }
            public string Phone
            {
                get { return _phone; }
                set { _phone = value; }
            }
            public bool IsActive
            {
                get { return _isActive; }
                set { _isActive = value; }
            }
            // Constructor for our member object
            public Member(int memberId, string name, string email, string phone, bool isActive)
            {
                _memberId = memberId;
                _name = name;
                _email = email;
                _phone = phone;
                _isActive = isActive;
            }
        }

         // our  list to store our Member objects 
        public List<Member> MembersList { get; private set; }

        // Our OnGet method, which is called when our page loads
        public void OnGet()
        {
            //Initializing our list of members
            MembersList = new List<Member>
            {
                // Adding members to the list
                new Member(1, "Signe Hansen", "Signehansen@gmail.com", "34829482", true),
                new Member(2, "Johanes Lysholm", "Johaneslysholm@gmail.com", "34829482", true),
                new Member(3, "Lene Krell", "Lenekrell@gmail.com", "34829482", false)
            };


        }



    }
}


