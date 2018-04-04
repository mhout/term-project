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

        public int ReservationID
        {
            get
            {
                return reservationID;
            }

            set
            {
                reservationID = value;
            }
        }

        public int HotelID
        {
            get
            {
                return hotelID;
            }

            set
            {
                hotelID = value;
            }
        }

        public int RoomNumber
        {
            get
            {
                return roomNumber;
            }

            set
            {
                roomNumber = value;
            }
        }

        public string CustomerName
        {
            get
            {
                return customerName;
            }

            set
            {
                customerName = value;
            }
        }

        public string CustomerPhone
        {
            get
            {
                return customerPhone;
            }

            set
            {
                customerPhone = value;
            }
        }

        public string CustomerEmail
        {
            get
            {
                return customerEmail;
            }

            set
            {
                customerEmail = value;
            }
        }

        public double TotalCost
        {
            get
            {
                return totalCost;
            }

            set
            {
                totalCost = value;
            }
        }

        public DateTime CheckInDate
        {
            get
            {
                return checkInDate;
            }

            set
            {
                checkInDate = value;
            }
        }

        public DateTime CheckOutDate
        {
            get
            {
                return checkOutDate;
            }

            set
            {
                checkOutDate = value;
            }
        }

        public int NumberAdults
        {
            get
            {
                return numberAdults;
            }

            set
            {
                numberAdults = value;
            }
        }

        public int NumberChildren
        {
            get
            {
                return numberChildren;
            }

            set
            {
                numberChildren = value;
            }
        }

        public string SpecialRequests
        {
            get
            {
                return specialRequests;
            }

            set
            {
                specialRequests = value;
            }
        }

        public string PaymentMethod
        {
            get
            {
                return paymentMethod;
            }

            set
            {
                paymentMethod = value;
            }
        }

        public string PaymentStatus
        {
            get
            {
                return paymentStatus;
            }

            set
            {
                paymentStatus = value;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public Reservation()
        {

        }
    }
}
