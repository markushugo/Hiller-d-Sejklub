using Microsoft.AspNetCore.Mvc.RazorPages;

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
            BoatsList.Add(new Boats(1, "Marie", "Sailboat", "12345", "Yamaha 4HP", 2010, true));
            BoatsList.Add(new Boats(2, "Lille Havfrue", "Motorboat", "67890", "Honda 10HP", 2015, false));
        }
    }
}
