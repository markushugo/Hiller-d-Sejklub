namespace Hillerød_Sejklub.Models
{
    // Model for en båd
    public class Boat
    {
        public int BoatId { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string SailNumber { get; set; }
        public string EngineInfo { get; set; }
        public int BuildYear { get; set; }
        public bool IsAvailable { get; set; }
        public string ImagePath { get; set; }

        public Boat(int boatId, string name, string model, string sailNumber, string engineInfo, int buildYear, bool isAvailable, string imagePath)
        {
            BoatId = boatId;
            Name = name;
            Model = model;
            SailNumber = sailNumber;
            EngineInfo = engineInfo;
            BuildYear = buildYear;
            IsAvailable = isAvailable;
            ImagePath = imagePath;
        }

        public override string ToString()
        {
            return $"{Name}, {Model}, {SailNumber}, {EngineInfo}, {BuildYear}, {IsAvailable}, {ImagePath}";
        }
    }
}
