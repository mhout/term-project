using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class Reservation
    {
        private int reservationID;
        private int hotelID;
        private int roomNumber;
        private string customerName;
        private string customerPhone;
        private string customerEmail;
        private double totalCost;
        private DateTime checkInDate;
        private DateTime checkOutDate;
        private int numberAdults;
        private int numberChildren;
        private string specialRequests;
        private string paymentMethod;
        private string paymentStatus;
        private string username;

        public int ReservationID { get => reservationID; set => reservationID = value; }
        public int HotelID { get => hotelID; set => hotelID = value; }
        public int RoomNumber { get => roomNumber; set => roomNumber = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
        public string CustomerPhone { get => customerPhone; set => customerPhone = value; }
        public string CustomerEmail { get => customerEmail; set => customerEmail = value; }
        public double TotalCost { get => totalCost; set => totalCost = value; }
        public DateTime CheckInDate { get => checkInDate; set => checkInDate = value; }
        public DateTime CheckOutDate { get => checkOutDate; set => checkOutDate = value; }
        public int NumberAdults { get => numberAdults; set => numberAdults = value; }
        public int NumberChildren { get => numberChildren; set => numberChildren = value; }
        public string SpecialRequests { get => specialRequests; set => specialRequests = value; }
        public string PaymentMethod { get => paymentMethod; set => paymentMethod = value; }
        public string PaymentStatus { get => paymentStatus; set => paymentStatus = value; }
        public string Username { get => username; set => username = value; }

        public Reservation()
        {

        }
    }
}
