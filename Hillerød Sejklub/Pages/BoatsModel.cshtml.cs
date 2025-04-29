using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using Hillerød_Sejklub.Pages;
using Hillerød_Sejklub.Models;

namespace Hillerød_Sejklub.Pages
{
    public class BoatsModel : PageModel
    {
        // Separate lists for our boats
        public List<Sailboat> Sailboats { get; set; }
        public List<Motorboat> Motorboats { get; set; }
        public List<Boats> BoatsList { get; set; }

        public void OnGet()
        {
            Sailboats = new List<Sailboat>
            {
                new Sailboat(1, "Marie", "Sailboat", "12345", "Yamaha 4HP", 2010, true, 2),
                new Sailboat(2, "Clara", "Sailboat", "67890", "Honda 10HP", 2015, false, 3)
            };

            Motorboats = new List<Motorboat>
            {
                new Motorboat(3, "Luna", "Motorboat", "54321", "Suzuki 15HP", 2018, true, "4-stroke"),
                new Motorboat(4, "Bella", "Motorboat", "09876", "Yamaha 20HP", 2020, false, "2-stroke")
            };

            BoatsList = new List<Boats>
            {

            };
        }
    }
}

