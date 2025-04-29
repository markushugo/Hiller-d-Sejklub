namespace Hillerød_Sejklub.Pages
{

    // Class representing repair request for a boat  
    public class RepairRequest
    {
        // Public properties for a repair request  
        public int Id { get; set; }
        public string BoatName { get; set; } // Fix type mismatch: Change type from int to string  
        public string ProblemDescription { get; set; }
        public bool IsFixed { get; set; }

        // Constructor for repair request  
        public RepairRequest(int id, string boatName, string problemDescription, bool isFixed)
        {
            Id = id;
            BoatName = boatName;
            ProblemDescription = problemDescription;
            IsFixed = isFixed;
        }
    }
}