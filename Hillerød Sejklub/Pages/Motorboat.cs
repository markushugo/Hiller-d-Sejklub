using Hillerød_Sejklub.Models;

namespace Hillerød_Sejklub.Models
{
    // Motorboat class inheriting from Boats
    public class Motorboat : Boats
    {
        // Motorboat-specific properties can be added here if needed
        public string EngineType { get; set; } 

        // Constructor for Motorboat class
        public Motorboat(int boatID, string name, string model, string sailNumber, string engineInfo, int buildYear, bool isAvailable, string engineType) : base(boatID, name, model, sailNumber, engineInfo, buildYear, isAvailable)
        {
            // Assigning the engine type to the property
            EngineType = engineType;
        }
    }
    
    }

