using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPA_Desktop.Connection;
using TPA_Desktop.Model;

namespace TPA_Desktop.Repository.MaintenenceDeptRepository
{
    class MaintenenceRepository
    {
        private static DatabaseEntities db = Connect.getInstance();

        public static List<Maintenence> getAll()
        {
            return db.Maintenences.Where(m => m.Status == "Under maintenence").ToList();
        }

        public static void update(int id, string information)
        {
            var m = find(id);

            m.Information = information;

            db.SaveChanges();
        }

        public static void remove(int id)
        {
            var m = find(id);

            m.Status = "Finished";
            db.SaveChanges();
        }

        public static Maintenence find(int id)
        {
            return (from maintenence in db.Maintenences
                    where maintenence.Id == id
                    select maintenence).FirstOrDefault();
        }

        public static void add(Maintenence m)
        {
            db.Maintenences.Add(m);
            db.SaveChanges();
        }
    }
}
