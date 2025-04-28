using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Hillerød_Sejklub.Pages
{
    public class BoatsModel : PageModel
    {
        public class Boat
        {
            private int BoatId { get; set; }
            private string Name { get; set; }
            private string Model { get; set; }
            private string SailNumber { get; set; }
            private string EngineInfo { get; set; }
            private int BuildYear { get; set; }
            private bool IsAvailable { get; set; }

            public Boat(int boatID, string name, string model, string sailNumber, string engineInfo, int builderYear, bool isAvailable)
            {
                Name = name;
                Model = model;
                SailNumber = sailNumber;
                EngineInfo = engineInfo;
                BuildYear = builderYear;
                IsAvailable = isAvailable;

            }
            public override string ToString()
            {
                return $"{Name},{Model},{SailNumber},{EngineInfo}, {IsAvailable}";
            }

            // public List<Maintenance> MaintenanceLog { get; set; } = new();
        }
        public void OnGet()
        {
        }
    }
}
