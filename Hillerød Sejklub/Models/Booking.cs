namespace Hillerød_Sejklub.Models
{
    public class boatBooking
    {
        public int BookingID { get; set; }
        public int BådID { get; set; }
        public int MedlemsID { get; set; }
        public DateTime SejlTid { get; set; }
        public string Mødested { get; set; }



        List<boatBooking> bookings = new List<boatBooking>();

        public int GenerateBookingID()
        {
            return BookingID++;
        }

        public void BookBåd(int bådID, int medlemsID, DateTime sejlTid, string mødested)
        {
            // Generer et unikt ID for booking (f.eks. øjebliksbillede eller tæl op)
            int nyBookingID = GenerateBookingID();

            // Opret en ny booking
            boatBooking nyBooking = new boatBooking
            {
                BookingID = nyBookingID,
                BådID = bådID,
                MedlemsID = medlemsID,
                SejlTid = sejlTid,
                Mødested = mødested
            };



            // Gem bookingen
            bookings.Add(nyBooking);

            Console.WriteLine("Båd er blevet booket.");
        }


        public bool ErBådTilgængelig(int bådID, DateTime ønsketTid)
        {
            foreach (var booking in bookings)
            {
                if (booking.BådID == bådID && booking.SejlTid == ønsketTid)
                {
                    return false; // Båden er allerede booket
                }
            }
            return true; // Båden er tilgængelig
        }
    }
}
