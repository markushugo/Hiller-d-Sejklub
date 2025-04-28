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
            BoatsList.Add(new Sailboat(1, "Aurora", "Sailboat", "15311", "Yamaha 6HP", 2012, true, 2)); // 2 sails
            BoatsList.Add(new Motorboat(2, "Neptune", "Motorboat", "12572", "Honda 15HP", 2018, false, "Outboard Engine")); // outboard engine
            BoatsList.Add(new Sailboat(3, "Odyssey", "Sailboat", "32653", "Mercury 5HP", 2015, true, 3)); // 3 sails
            BoatsList.Add(new Motorboat(4, "Marlin", "Motorboat", "13474", "Suzuki 8HP", 2017, true, "Inboard Engine")); // inboard engine
            BoatsList.Add(new Sailboat(5, "Luna", "Sailboat", "92834", "Tohatsu 4HP", 2009, true, 2)); // 2 sails
            BoatsList.Add(new Motorboat(6, "Triton", "Motorboat", "59182", "Yamaha 20HP", 2021, false, "Outboard Engine")); // outboard engine
            BoatsList.Add(new Sailboat(7, "Seabreeze", "Sailboat", "058302", "Yamaha 5HP", 2011, true, 4)); // 4 sails
            BoatsList.Add(new Motorboat(8, "Viking", "Motorboat", "95823", "Honda 12HP", 2014, true, "Inboard Engine")); // inboard engine
            BoatsList.Add(new Sailboat(9, "Coral", "Sailboat", "50128", "Mercury 7HP", 2013, true, 3)); // 3 sails
            BoatsList.Add(new Motorboat(10, "Poseidon", "Motorboat", "15029", "Suzuki 9.9HP", 2020, false, "Outboard Engine")); // outboard engine

        }
    }
}
