namespace Hillerød_Sejklub.Models
{
    public class Member
    {
        // our private fields
        private string _name;
        private string _email;
        private string _phoneNumber;
        private string _address;
        private string _city;


        // our public properties 
        public string Name { get => _name; set => _name = value; }

        public string Email { get => _email; set => _email = value; }

        public string PhoneNr { get => _phoneNumber; set => _phoneNumber = value; }

        public string Address { get => _address; set => _address = value; }

        public string City { get => _city; set => _city = value; }

        // our constructor


        public Member(string name, string email, string phoneNumber, string address, string city)
        {
            _name = name;
            _email = email;
            _phoneNumber = phoneNumber;
            _address = address;
            _city = city;
        }







    }
}
