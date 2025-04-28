using Hillerød_Sejklub.Models;

namespace Hillerød_Sejklub.Pages
{
    public class Motorboat : Boats
    {
        // Constructor for Motorboat class
        public Motorboat(int boatID, string name, string model, string sailNumber, string engineInfo, int buildYear, bool isAvailable, string v) : base(boatID, name, model, sailNumber, engineInfo, buildYear, isAvailable)
        {
        }
    }
    
    }

