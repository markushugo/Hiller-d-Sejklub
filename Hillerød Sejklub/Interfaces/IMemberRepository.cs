using System.Collections.Generic;
using Hillerød_Sejklub.Models;

namespace Hillerød_Sejklub.Interfaces
{
    // Interface for medlem repo
    public interface IMemberRepository
    {
        // Returnerer alle medlemmer
        List<Member> GetAll();

        // Tilføjer et nyt medlem
        void Add(Member newMember);

        // Søger efter medlemmer ud fra navn / email
        List<Member> Search(string searchText);
    }
}

