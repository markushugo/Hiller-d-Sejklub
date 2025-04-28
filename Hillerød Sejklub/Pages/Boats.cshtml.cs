using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Hillerød_Sejklub.Pages
{
    public class BoatsModel : PageModel
    {
        public class Boat
        {
            public int BoatId { get; set; }
            public string Name { get; set; }
            public string Model { get; set; }
            public string SailNumber { get; set; }
            public string EngineInfo { get; set; }
            public int BuildYear { get; set; }
            public bool IsAvailable { get; set; }
            public Boat(int BoatID, string name, string model, string sailNumber, string engineInfo, int builderYear, bool isAvailable)
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
