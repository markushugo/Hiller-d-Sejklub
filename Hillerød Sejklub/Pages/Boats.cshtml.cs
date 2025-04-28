using System;

namespace Hillerød_Sejklub.Models
{
    // our superclass representing Boats 
    public class Boats
    {
        // our private fields
        private int _boatId;
        private string _name;
        private string _model;
        private string _sailNumber;
        private string _engineInfo;
        private int _buildYear;
        private bool _isAvailable;
        

        // our constructor
        public Boats(int boatID, string name, string model, string sailNumber, string engineInfo, int buildYear, bool isAvailable)
        {
            _boatId = boatID;
            _name = name;
            _model = model;
            _sailNumber = sailNumber;
            _engineInfo = engineInfo;
            _buildYear = buildYear;
            _isAvailable = isAvailable;


        }
        // our public properties 
        public int BoatId
        {
            get { return _boatId; }
            set { _boatId = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public string SailNumber
        {
            get { return _sailNumber; }
            set { _sailNumber = value; }
        }
        public string EngineInfo
        {
            get { return _engineInfo; }
            set { _engineInfo = value; }
        }
        public int BuildYear
        {
            get { return _buildYear; }
            set { _buildYear = value; }
        }
        public bool IsAvailable
        {
            get { return _isAvailable; }
            set { _isAvailable = value; }
        }
        // method to get boat info
        public virtual string GetInfo()
        {
            return "Boat:" + _name + " Model:" + _model + " SailNumber:" + _sailNumber + " EngineInfo:" + _engineInfo + " BuildYear:" + _buildYear + " IsAvailable:" + _isAvailable;
        }
    }
}


