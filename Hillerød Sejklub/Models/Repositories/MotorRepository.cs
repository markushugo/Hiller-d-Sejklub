using System.Collections.Generic;
using Hillerød_Sejklub.Models;

namespace Hillerød_Sejklub.Models.Repositories
{
    // Repository til håndtering af motorer
    public class MotorRepository
    {
        // Liste over alle motorer
        private static List<Motor> _motors = new List<Motor>();

        // Tilføjer en motor 
        public void Add(Motor motor)
        {
            _motors.Add(motor);
        }

        // Returnerer alle motorer
        public List<Motor> GetAll()
        {
            return _motors;
        }
    }
}

