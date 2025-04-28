using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using Hillerød_Sejklub.Models;

namespace Hillerød_Sejklub.Pages
{
    public class BoatsModel : PageModel
    {
        // Public list of Boats
        public List<Boats> BoatsList { get; set; }

        public void OnGet()
        {
            // Initialize the list
            BoatsList = new List<Boats>();

            // Add boats one by one
            BoatsList.Add(new Sailboat(1, "Marie", "Sailboat", "12345", "Yamaha 4HP", 2010, true, 2)); // 2 sails 
            BoatsList.Add(new Motorboat(2, "Clara", "Motorboat", "67890", "Honda 10HP", 2015, false,"Outboard Engine")); // outboard engine
            BoatsList.Add(new Sailboat(3, "Lene", "speedster", "12345", "Yamaha 4HP", 2010, true, 3)); // 3 sails
            BoatsList.Add(new Motorboat(4, "Johan", "breeze", "12345", "Yamaha 4HP", 2010, true, "Inboard Engine")); // inboard engine
        }
    }
}
