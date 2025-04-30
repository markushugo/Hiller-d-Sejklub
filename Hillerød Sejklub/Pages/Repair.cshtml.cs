using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using Hillerød_Sejklub.Pages;

namespace Hillerød_Sejklub.Pages
{
    public class RepairModel : PageModel
    {
        // Liste over alle reparationer (gemmes i hukommelsen)
        public static List<RepairRequest> Repairs = new List<RepairRequest>();

        // Egenskab der bindes til formularens inputfelter
        [BindProperty]
        public RepairRequest NewRepair { get; set; } = new RepairRequest(0, "", "", false);

        // Kører når siden indlæses første gang (GET)
        public void OnGet()
        {
        }

        // Kører når formularen indsendes (POST) - tilføjer ny reparation
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            NewRepair.Id = Repairs.Count + 1;
            NewRepair.IsFixed = false;
            Repairs.Add(NewRepair);

            return RedirectToPage();
        }

        // Kører når brugeren klikker på "Markér som repareret"
        public IActionResult OnPostMarkAsRepaired(int id)
        {
            RepairRequest repair = Repairs.Find(r => r.Id == id);

            if (repair != null)
            {
                repair.IsFixed = true;
            }

            return RedirectToPage();
        }

        // Kører når brugeren klikker på "Slet"
        public IActionResult OnPostDelete(int id)
        {
            for (int i = 0; i < Repairs.Count; i++)
            {
                if (Repairs[i].Id == id)
                {
                    Repairs.RemoveAt(i);
                    break;
                }
            }

            return RedirectToPage();
        }
    }
}
