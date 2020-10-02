using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPA_Desktop.Model;

namespace TPA_Desktop.Factory.HotelDeptFactory
{
    class ReservationFactory
    {
        public static Reservation create(int employeeId, int visitorId, int roomId, string checkIn, int night, int totalPrice)
        {
            Reservation r = new Reservation();
            r.EmployeeId = employeeId;
            r.VisitorId = visitorId;
            r.RoomId = roomId;
            r.CheckInDate = "";
            r.CheckOutDate = "";
            r.Night = night;
            r.TotalPrice = totalPrice;
            r.Status = "Booked";

            return r;
        }


    }
}
