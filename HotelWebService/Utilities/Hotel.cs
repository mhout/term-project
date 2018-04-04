using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    class Hotel
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

        public int HotelID { get => hotelID; set => hotelID = value; }
        public string HotelName { get => hotelName; set => hotelName = value; }
        public string Address { get => address; set => address = value; }
        public string City { get => city; set => city = value; }
        public string Zip { get => zip; set => zip = value; }
        public string Phone { get => phone; set => phone = value; }
        public int RoomCount { get => roomCount; set => roomCount = value; }
        public int RoomsAvailable { get => roomsAvailable; set => roomsAvailable = value; }
        public string Wifi { get => wifi; set => wifi = value; }
        public string RoomService { get => roomService; set => roomService = value; }
        public int Rating { get => rating; set => rating = value; }

        public Hotel()
        {

        }
    }
}
