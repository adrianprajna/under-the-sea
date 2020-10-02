using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPA_Desktop.Connection;
using TPA_Desktop.Model;

namespace TPA_Desktop.Repository.HotelDeptRepository
{
    class ReservationRepository
    {
        private static DatabaseEntities db = Connect.getInstance();

        public static List<Reservation> getAll()
        {
            return db.Reservations.ToList();
        }

        public static void add(Reservation r)
        {
            db.Reservations.Add(r);
            db.SaveChanges();
        }

        public static Reservation find(int id)
        {
            return db.Reservations.Where(x => x.Id == id).FirstOrDefault();
        }

        public static void update(int id, string status, Room room)
        {
            var r = find(id);

            if(status == "Check in")
            {
                r.CheckInDate = DateTime.Now.ToString();
                DateTime checkout = DateTime.Today.AddDays((int)r.Night);
                r.CheckOutDate = checkout.ToString();
            }
            else
            {
                room.Status = "Available";
                r.CheckOutDate = DateTime.Now.ToString();
            }

            r.Status = status;
            db.SaveChanges();
        }

        public static void remove(int id, Room room)
        {
            var r = find(id);

            r.Status = "Cancelled";
            room.Status = "Available";

            db.SaveChanges();
        }

        public static void update(int id, int night)
        {
            var r = find(id);

            r.Night = night;

            if(r.Status == "Check in")
            {
                DateTime checkout = DateTime.Today.AddDays(night);
                r.CheckOutDate = checkout.ToString();
            }

            r.TotalPrice = night * r.Room.Price;

            db.SaveChanges();
        }
    }
}
