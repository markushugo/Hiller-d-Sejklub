using System.Collections.Generic;
using Hillerød_Sejklub.Models;
using Hillerød_Sejklub.Interfaces;

namespace Hillerød_Sejklub.Models.Repo
{
    // Repository til medlemmer af Hillerød Sejklub
    public class MemberRepository : IMemberRepository
    {
        private static List<Member> _members = new List<Member>
        {
            new Member(1, "Emma Jensen", "emma.jensen@gmail.com", "12345678", true),
            new Member(2, "William Nielsen", "william.nielsen@gmail.com", "87654321", false),
            new Member(3, "Ida Sørensen", "ida.sorensen@gmail.com", "23456789", true),
            new Member(4, "Noah Kristensen", "noah.kristensen@gmail.com", "98765432", true),
            new Member(5, "Freja Larsen", "freja.larsen@gmail.com", "34567890", false),
            new Member(6, "Lucas Pedersen", "lucas.pedersen@gmail.com", "45678901", true),
            new Member(7, "Sofie Madsen", "sofie.madsen@gmail.com", "56789012", true),
            new Member(8, "Oliver Hansen", "oliver.hansen@gmail.com", "67890123", false),
            new Member(9, "Clara Poulsen", "clara.poulsen@gmail.com", "78901234", true),
            new Member(10, "Victor Mortensen", "victor.mortensen@gmail.com", "89012345", true),
            new Member(11, "Anna Thomsen", "anna.thomsen@gmail.com", "90123456", false),
            new Member(12, "Magnus Rasmussen", "magnus.rasmussen@gmail.com", "01234567", true),
            new Member(13, "Laura Andersen", "laura.andersen@gmail.com", "12345098", true),
            new Member(14, "Malthe Olesen", "malthe.olesen@gmail.com", "23450987", false),
            new Member(15, "Josefine Holm", "josefine.holm@gmail.com", "34509876", true),
            new Member(16, "Mikkel Vestergaard", "mikkel.vestergaard@gmail.com", "45098765", true),
            new Member(17, "Mathilde Bjerregaard", "mathilde.bjerregaard@gmail.com", "50987654", false),
            new Member(18, "Emil Frederiksen", "emil.frederiksen@gmail.com", "09876543", true),
            new Member(19, "Amalie Carlsen", "amalie.carlsen@gmail.com", "98765432", true),
            new Member(20, "Anton Lauridsen", "anton.lauridsen@gmail.com", "87654321", false),
            new Member(21, "Julie Iversen", "julie.iversen@gmail.com", "76543210", true),
            new Member(22, "Mads Jeppesen", "mads.jeppesen@gmail.com", "65432109", true),
            new Member(23, "Caroline Bundgaard", "caroline.bundgaard@gmail.com", "54321098", false),
            new Member(24, "Andreas Schou", "andreas.schou@gmail.com", "43210987", true),
            new Member(25, "Alma Dalsgaard", "alma.dalsgaard@gmail.com", "32109876", true),
            new Member(26, "Sebastian Munk", "sebastian.munk@gmail.com", "21098765", false),
            new Member(27, "Lærke Storm", "laerke.storm@gmail.com", "10987654", true),
            new Member(28, "Oscar Bay", "oscar.bay@gmail.com", "09876543", true),
            new Member(29, "Signe Kjær", "signe.kjaer@gmail.com", "98765432", false),
            new Member(30, "Jonathan Vang", "jonathan.vang@gmail.com", "87654321", true)
        };

        // Returnerer alle medlemmer
        public List<Member> GetAll()
        {
            return _members;
        }

        // Tilføjer nyt medlem
        public void Add(Member newMember)
        {
            _members.Add(newMember);
        }

        // Søger efter medlemmer, enten ved navn eller email
        public List<Member> Search(string searchText)
        {
            List<Member> result = new List<Member>();

            foreach (Member member in _members)
            {
                if (member.Name.ToLower().Contains(searchText.ToLower()) ||
                    member.Email.ToLower().Contains(searchText.ToLower()))
                {
                    result.Add(member);
                }
            }

            return result;
        }
    }
}
