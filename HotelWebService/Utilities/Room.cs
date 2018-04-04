using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    class Room
    {
        private int roomNumber;
        private string roomDescription;
        private string roomType;
        private int numberBeds;
        private int sleeps;
        private string view;
        private double rate;
        private string status;

        public int RoomNumber { get => roomNumber; set => roomNumber = value; }
        public string RoomDescription { get => roomDescription; set => roomDescription = value; }
        public string RoomType { get => roomType; set => roomType = value; }
        public int NumberBeds { get => numberBeds; set => numberBeds = value; }
        public int Sleeps { get => sleeps; set => sleeps = value; }
        public string View { get => view; set => view = value; }
        public double Rate { get => rate; set => rate = value; }
        public string Status { get => status; set => status = value; }

        public Room()
        {

        }
    }
}
