using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPA_Desktop.Connection;
using TPA_Desktop.Model;

namespace TPA_Desktop.Repository.HotelDeptRepository
{
    class RoomRepository
    {

        private static DatabaseEntities db = Connect.getInstance();

        public static List<Room> getAll()
        {
            return db.Rooms.ToList();
        }


        public static Room find(int id)
        {
            return db.Rooms.Where(r => r.Id == id).FirstOrDefault();
        }

        public static void update(int id)
        {
            var room = find(id);

            if (room.Status == "Available")
                room.Status = "Booked";

            else
                room.Status = "Available";

            db.SaveChanges();
        }
    }
}
