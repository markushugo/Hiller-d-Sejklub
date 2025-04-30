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
                   new Sailboat(1, "Marie", "Sailboat", "12345", "Yamaha 4HP", 2010, true, 2, "sailboat1.jpg"),
                   new Sailboat(2, "Clara", "Sailboat", "67890", "Honda 10HP", 2015, false, 3, "sailboat2.jpg"),
                   new Sailboat(3, "Freja", "Sailboat", "11111", "Tohatsu 6HP", 2018, true, 2, "sailboat3.jpg"),
                   new Sailboat(4, "Sofie", "Sailboat", "22222", "Mercury 8HP", 2022, true, 1, "sailboat4.jpg")
                };

            Motorboats = new List<Motorboat>
                {
                   new Motorboat(3, "Luna", "Motorboat", "54321", "Suzuki 15HP", 2018, true, "4-stroke", "motorboat1.jpg"),
                   new Motorboat(4, "Bella", "Motorboat", "09876", "Yamaha 20HP", 2020, false, "2-stroke", "motorboat2.jpg"),
                   new Motorboat(5, "Stella", "Motorboat", "11223", "Mercury 25HP", 2021, true, "4-stroke", "motorboat3.jpg"),
                   new Motorboat(6, "Nova", "Motorboat", "33445", "Honda 30HP", 2019, true, "4-stroke", "motorboat4.jpg")
                };

            BoatsList = new List<Boats>
            {

            };
        }
    }
}

