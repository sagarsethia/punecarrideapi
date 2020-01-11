using System;

namespace PuneCarRideApi.model
{
    public class Booking
    {
        public int BookingId { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string PickUpDate { get; set; }
        public string DropDate { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public string CustomerAddress { get; set; }
        public string TripCharges { get; set; }

        public string CustomerName { get; set; }
    }
}