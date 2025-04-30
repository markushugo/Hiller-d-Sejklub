using System;

namespace Hillerød_Sejklub.Models
{
    // Model for bådbooking
    public class BoatBooking
    {
        public int BookingID { get; set; }
        public int BådID { get; set; }
        public int MedlemsID { get; set; }
        public DateTime SejlTid { get; set; }
        public string Mødested { get; set; }
    }
}
