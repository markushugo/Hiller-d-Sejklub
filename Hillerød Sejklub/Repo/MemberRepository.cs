using System.Collections.Generic;
using Hillerød_Sejklub.Pages;
using Hillerød_Sejklub.Repo;

namespace Hillerød_Sejklub.Repo
{
    public class MemberRepository
    {
        // Liste med alle medlemmer
        private static List<MembersModel.Member> _members = new List<MembersModel.Member>
        {
            new MembersModel.Member(1, "Emma Jensen", "emma.jensen@gmail.com", "12345678", true),
            new MembersModel.Member(2, "William Nielsen", "william.nielsen@gmail.com", "87654321", false),
            new MembersModel.Member(3, "Ida Sørensen", "ida.sorensen@gmail.com", "23456789", true),
            new MembersModel.Member(4, "Noah Kristensen", "noah.kristensen@gmail.com", "98765432", true),
            new MembersModel.Member(5, "Freja Larsen", "freja.larsen@gmail.com", "34567890", false),
            new MembersModel.Member(6, "Lucas Pedersen", "lucas.pedersen@gmail.com", "45678901", true),
            new MembersModel.Member(7, "Sofie Madsen", "sofie.madsen@gmail.com", "56789012", true),
            new MembersModel.Member(8, "Oliver Hansen", "oliver.hansen@gmail.com", "67890123", false),
            new MembersModel.Member(9, "Clara Poulsen", "clara.poulsen@gmail.com", "78901234", true),
            new MembersModel.Member(10, "Victor Mortensen", "victor.mortensen@gmail.com", "89012345", true),
            new MembersModel.Member(11, "Anna Thomsen", "anna.thomsen@gmail.com", "90123456", false),
            new MembersModel.Member(12, "Magnus Rasmussen", "magnus.rasmussen@gmail.com", "01234567", true),
            new MembersModel.Member(13, "Laura Andersen", "laura.andersen@gmail.com", "12345098", true),
            new MembersModel.Member(14, "Malthe Olesen", "malthe.olesen@gmail.com", "23450987", false),
            new MembersModel.Member(15, "Josefine Holm", "josefine.holm@gmail.com", "34509876", true),
            new MembersModel.Member(16, "Mikkel Vestergaard", "mikkel.vestergaard@gmail.com", "45098765", true),
            new MembersModel.Member(17, "Mathilde Bjerregaard", "mathilde.bjerregaard@gmail.com", "50987654", false),
            new MembersModel.Member(18, "Emil Frederiksen", "emil.frederiksen@gmail.com", "09876543", true),
            new MembersModel.Member(19, "Amalie Carlsen", "amalie.carlsen@gmail.com", "98765432", true),
            new MembersModel.Member(20, "Anton Lauridsen", "anton.lauridsen@gmail.com", "87654321", false),
            new MembersModel.Member(21, "Julie Iversen", "julie.iversen@gmail.com", "76543210", true),
            new MembersModel.Member(22, "Mads Jeppesen", "mads.jeppesen@gmail.com", "65432109", true),
            new MembersModel.Member(23, "Caroline Bundgaard", "caroline.bundgaard@gmail.com", "54321098", false),
            new MembersModel.Member(24, "Andreas Schou", "andreas.schou@gmail.com", "43210987", true),
            new MembersModel.Member(25, "Alma Dalsgaard", "alma.dalsgaard@gmail.com", "32109876", true),
            new MembersModel.Member(26, "Sebastian Munk", "sebastian.munk@gmail.com", "21098765", false),
            new MembersModel.Member(27, "Lærke Storm", "laerke.storm@gmail.com", "10987654", true),
            new MembersModel.Member(28, "Oscar Bay", "oscar.bay@gmail.com", "09876543", true),
            new MembersModel.Member(29, "Signe Kjær", "signe.kjaer@gmail.com", "98765432", false),
            new MembersModel.Member(30, "Jonathan Vang", "jonathan.vang@gmail.com", "87654321", true)
        };

        // Returnerer listen af medlemmer
        public List<MembersModel.Member> GetAll()
        {
            return _members;
        }
    }
}
