using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class Room
    {
        private int roomNumber;
        private string roomDescription;
        private string roomType;
        private int numberBeds;
        private int sleeps;
        private string view;
        private double rate;
        private string status;

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

        public string RoomDescription
        {
            get
            {
                return roomDescription;
            }

            set
            {
                roomDescription = value;
            }
        }

        public string RoomType
        {
            get
            {
                return roomType;
            }

            set
            {
                roomType = value;
            }
        }

        public int NumberBeds
        {
            get
            {
                return numberBeds;
            }

            set
            {
                numberBeds = value;
            }
        }

        public int Sleeps
        {
            get
            {
                return sleeps;
            }

            set
            {
                sleeps = value;
            }
        }

        public string View
        {
            get
            {
                return view;
            }

            set
            {
                view = value;
            }
        }

        public double Rate
        {
            get
            {
                return rate;
            }

            set
            {
                rate = value;
            }
        }

        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        public Room()
        {

        }
    }
}
