using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hillerød_Sejklub.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hillerød_Sejklub.Pages
{
    public class BegivenhederModel : PageModel
    {
        // Lister til at gemme begivenheder og tilmeldinger
        public static List<Begivenhed> Begivenheder = new List<Begivenhed>();
        public static List<Tilmelding> Tilmeldinger = new List<Tilmelding>();

        // Bindproperty gør det muligt at få adgang til værdierne fra vores formular 
        [BindProperty]
        public int MedlemsID { get; set; }

        [BindProperty]
        public int ValgtBegivenhedID { get; set; }

        [BindProperty]
        public string NyBegivenhedType { get; set; }

        [BindProperty]
        public DateTime NyBegivenhedDato { get; set; }

        // onget metode, dog tom 
        public void OnGet()
        {
            // tom 
        }


        // Metode til at oprette en ny begivenhed
        public IActionResult OnPostOpretBegivenhed()
        {

        // Opretter en ny begivenhed og tilføjer den til listen
            Begivenhed ny = new Begivenhed
            {
                Id = DateTime.Now.Millisecond,
                Type = NyBegivenhedType,
                Dato = NyBegivenhedDato
            };


            // tilføjer den nye begivenhed til listen
            Begivenheder.Add(ny);
            return RedirectToPage();
        }

        public IActionResult OnPostTilmeld()
        {
            Tilmelding ny = new Tilmelding
            {
                MedlemsID = MedlemsID,
                BegivenhedID = ValgtBegivenhedID
            };

            // opdater siden 
            Tilmeldinger.Add(ny);
            return RedirectToPage();
        }
    }
}
