using Hillerød_Sejklub.Models;

namespace Hillerød_Sejklub.Pages
{
    public class Sailboat : Boats
    {
        // Constructor for Sailboat class
        public Sailboat(int boatID, string name, string model, string sailNumber, string engineInfo, int buildYear, bool isAvailable, int v) : base(boatID, name, model, sailNumber, engineInfo, buildYear, isAvailable)
        {

        }
    }
}
