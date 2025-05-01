using Microsoft.AspNetCore.Mvc.RazorPages;

public class Medlemskab
{
    public string Navn { get; set; }
    public string Pris { get; set; }
}

public class MembershipModel : PageModel
{
    public List<Medlemskab> Medlemskaber { get; set; }

    public void OnGet()
    {
        Medlemskaber = new List<Medlemskab>
        {
            new Medlemskab { Navn = "Junior", Pris = "750kr" },
            new Medlemskab { Navn = "Junior inkl. pladsleje", Pris = "950kr" },
            new Medlemskab { Navn = "Senior", Pris = "1100kr" },
            new Medlemskab { Navn = "Senior inkl. pladsleje", Pris = "1500kr" },
            new Medlemskab { Navn = "Familie", Pris = "1500kr" },
            new Medlemskab { Navn = "Bådplads", Pris = "400kr" }
        };
    }
}
