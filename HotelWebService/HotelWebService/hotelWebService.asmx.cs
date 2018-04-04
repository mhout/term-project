using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using System.Data;
using System.Data.SqlClient;
using Utilities;

namespace HotelWebService
{
    /// <summary>
    /// Summary description for hotelWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class hotelWebService : System.Web.Services.WebService
    {
        DBConnect objDB;
        SqlCommand objCommand;

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public DataSet GetHotels(string city, string state)
        {
            objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "tp_getHotelsByCityState";
            objCommand.Parameters.AddWithValue("@city", city);
            objCommand.Parameters.AddWithValue("@state", state);
            objDB = new DBConnect();
            DataSet ds;
            ds = objDB.GetDataSetUsingCmdObj(objCommand);
            return ds;
        }

        [WebMethod]
        public DataSet GetRoomsByHotel(Hotel hotel)
        {
            objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "tp_getRoomsByHotel";
            objCommand.Parameters.AddWithValue("@hotelID", hotel.HotelID);
            objDB = new DBConnect();
            DataSet ds;
            ds = objDB.GetDataSetUsingCmdObj(objCommand);
            return ds;
        }

        [WebMethod]
        public DataSet FindRooms(Room room, string city, string state)
        {
            objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "tp_FindRooms";
            objCommand.Parameters.AddWithValue("@city", city);
            objCommand.Parameters.AddWithValue("@state", state);
            objCommand.Parameters.AddWithValue("@roomType",room.RoomType);
            objCommand.Parameters.AddWithValue("@numBeds", room.NumberBeds);
            objCommand.Parameters.AddWithValue("@sleeps", room.Sleeps);
            objCommand.Parameters.AddWithValue("@view", room.View);
            objDB = new DBConnect();
            DataSet ds;
            ds = objDB.GetDataSetUsingCmdObj(objCommand);
            return ds;
        }

        [WebMethod]
        public DataSet FindRoomsByHotel(Hotel hotel, Room room, string city, string state)
        {
            objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "tp_FindRoomsInHotel";
            objCommand.Parameters.AddWithValue("@city", city);
            objCommand.Parameters.AddWithValue("@state", state);
            objCommand.Parameters.AddWithValue("@roomType", room.RoomType);
            objCommand.Parameters.AddWithValue("@numBeds", room.NumberBeds);
            objCommand.Parameters.AddWithValue("@sleeps", room.Sleeps);
            objCommand.Parameters.AddWithValue("@view", room.View);
            objCommand.Parameters.AddWithValue("@hotelID", hotel.HotelID);
            objDB = new DBConnect();
            DataSet ds;
            ds = objDB.GetDataSetUsingCmdObj(objCommand);
            return ds;
        }

        [WebMethod]
        public bool Reserve(Hotel hotel, Room room, Customer customer, Reservation reservation string userID, string password)
        {
            objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "tp_Reserve";
            objCommand.Parameters.AddWithValue("@hotelID", hotel.HotelID);
            objCommand.Parameters.AddWithValue("@roomNumber", room.RoomNumber);
            objCommand.Parameters.AddWithValue("@customerName", customer.Name);
            objCommand.Parameters.AddWithValue("@customerPhone", customer.Phone);
            objCommand.Parameters.AddWithValue("@customerEmail", customer.Email);
            objCommand.Parameters.AddWithValue("@totalCost",reservation.TotalCost);
            objCommand.Parameters.AddWithValue("@checkInDate",reservation.CheckInDate);
            objCommand.Parameters.AddWithValue("@checkOutDate", reservation.CheckOutDate);
            objCommand.Parameters.AddWithValue("@numberAdults", reservation.NumberAdults);
            objCommand.Parameters.AddWithValue("@numberChildren", reservation.NumberChildren);
            objCommand.Parameters.AddWithValue("@specialRequests", reservation.SpecialRequests);
            objCommand.Parameters.AddWithValue("@paymentMethod", reservation.PaymentMethod);
            objCommand.Parameters.AddWithValue("@paymentStatus", reservation.PaymentStatus);
            objCommand.Parameters.AddWithValue("@username", reservation.Username);
            objDB = new DBConnect();
            int returnValue = objDB.DoUpdateUsingCmdObj(objCommand);
            if(returnValue != -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool getPassword(string username,string password)
        {
            objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "tp_authorizeUser";
            objCommand.Parameters.AddWithValue("@user", username);
            objDB = new DBConnect();
            int count;
            DataSet ds = objDB.GetDataSetUsingCmdObj(objCommand,out count);
            if(count == 0)
            {
                return false;
            }
            else if (count > 1)
            {
                return false;
            }

            string storedPassword = ds.Tables[0].Rows[0]["password"].ToString();
            if(password == storedPassword)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
