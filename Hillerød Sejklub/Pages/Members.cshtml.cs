using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using Hillerød_Sejklub.Models;
using Hillerød_Sejklub.Models.Repo;

namespace Hillerød_Sejklub.Pages
{
    public class MembersModel : PageModel
    {
        // Repository objekt til at hente medlemmer
        private MemberRepository _repo = new MemberRepository();

        // Liste med medlemmer
        public List<Member> MembersList { get; private set; }

        // metode til at hente medlemmer
        public void OnGet()
        {
            MembersList = _repo.GetAll();
        }
    }
}
