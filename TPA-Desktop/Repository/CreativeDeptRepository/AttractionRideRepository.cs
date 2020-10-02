using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPA_Desktop.Connection;
using TPA_Desktop.Model;

namespace TPA_Desktop.Repository.CreativeDeptRepository
{
    class AttractionRideRepository
    {
        private static DatabaseEntities db = Connect.getInstance();

        public static List<AttractionRide> getAll()
        {
            return db.AttractionRides.Where(a => a.Status == "Active" || a.Status == "Under maintenence").ToList();
        }

        public static bool add(AttractionRide a)
        {
            db.AttractionRides.Add(a);
            db.SaveChanges();

            return true;
        }

        public static void update(int id, string name, string description)
        {
            var attr_ride = find(id);

            attr_ride.Name = name;
            attr_ride.Description = description;

            db.SaveChanges();
        }

        public static void updtMaintenence(int id)
        {
            var attr_ride = find(id);

            if (attr_ride.Status == "Active")
                attr_ride.Status = "Under maintenence";
            else
                attr_ride.Status = "Active";

            db.SaveChanges();
        }

        public static void remove(int id)
        {
            var attr_ride = find(id);

            attr_ride.Status = "Inactive";
            db.SaveChanges();
        }

        public static AttractionRide find(int id)
        {
            return (from attr in db.AttractionRides
                    where attr.Id == id
                    select attr).FirstOrDefault();
        }

    }
}
