using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class Hotel
    {
        private int hotelID;
        private string hotelName;
        private string address;
        private string city;
        private string zip;
        private string phone;
        private int roomCount;
        private int roomsAvailable;
        private string wifi;
        private string roomService;
        private int rating;

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

        public string HotelName
        {
            get
            {
                return hotelName;
            }

            set
            {
                hotelName = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }

        public string Zip
        {
            get
            {
                return zip;
            }

            set
            {
                zip = value;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }

        public int RoomCount
        {
            get
            {
                return roomCount;
            }

            set
            {
                roomCount = value;
            }
        }

        public int RoomsAvailable
        {
            get
            {
                return roomsAvailable;
            }

            set
            {
                roomsAvailable = value;
            }
        }

        public string Wifi
        {
            get
            {
                return wifi;
            }

            set
            {
                wifi = value;
            }
        }

        public string RoomService
        {
            get
            {
                return roomService;
            }

            set
            {
                roomService = value;
            }
        }

        public int Rating
        {
            get
            {
                return rating;
            }

            set
            {
                rating = value;
            }
        }

        public Hotel()
        {

        }
    }
}
