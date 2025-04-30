using System;
using System.Collections.Generic;
using Hillerød_Sejklub.Models;

namespace Hillerød_Sejklub.Models.Repositories
{
    public class BoatBookingRepository
    {
        private static List<BoatBooking> _bookings = new List<BoatBooking>();
        private static int _nextId = 1;

        public void BookBåd(int bådID, int medlemsID, DateTime sejlTid, string mødested)
        {
            if (!ErBådTilgængelig(bådID, sejlTid))
            {
                Console.WriteLine("Båden er ikke ledig på det tidspunkt.");
                return;
            }

            BoatBooking nyBooking = new BoatBooking
            {
                BookingID = _nextId++,
                BådID = bådID,
                MedlemsID = medlemsID,
                SejlTid = sejlTid,
                Mødested = mødested
            };

            _bookings.Add(nyBooking);
            Console.WriteLine("Båd er blevet booket.");
        }

        public bool ErBådTilgængelig(int bådID, DateTime ønsketTid)
        {
            foreach (BoatBooking booking in _bookings)
            {
                if (booking.BådID == bådID && booking.SejlTid == ønsketTid)
                {
                    return false;
                }
            }
            return true;
        }

        public List<BoatBooking> GetAll()
        {
            return _bookings;
        }
    }
}
