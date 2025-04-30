using System.Collections.Generic;
using Hillerød_Sejklub.Models;

namespace Hillerød_Sejklub.Models.Repositories
{
    // Repository til at håndtere både
    public class BoatRepository
    {
        private static List<Boat> _boats = new List<Boat>();

        public void Add(Boat boat)
        {
            _boats.Add(boat);
        }

        public List<Boat> GetAll()
        {
            return _boats;
        }

        public Boat FindById(int id)
        {
            foreach (Boat b in _boats)
            {
                if (b.BoatId == id)
                {
                    return b;
                }
            }
            return null;
        }

        public List<Boat> SearchByModel(string model)
        {
            List<Boat> result = new List<Boat>();
            foreach (Boat b in _boats)
            {
                if (b.Model.ToLower().Contains(model.ToLower()))
                {
                    result.Add(b);
                }
            }
            return result;
        }
    }
}
