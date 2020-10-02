using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPA_Desktop.Connection;
using TPA_Desktop.Model;

namespace TPA_Desktop.Repository.SalesDeptRepository
{
    class AdvertisementRepository
    {
        private static DatabaseEntities db = Connect.getInstance();

        public static List<Advertisement> getAll()
        {
            return (from adv in db.Advertisements
                    where adv.Status == "Active"
                    select adv).ToList();
        }

        public static void add(Advertisement a)
        {
            db.Advertisements.Add(a);
            db.SaveChanges();
        }

        public static void update(int id, string title, string description)
        {
            var advertisement = find(id);

            advertisement.Title = title;
            advertisement.Description = description;

            db.SaveChanges();
        }

        public static void remove(int id)
        {
            var advertisement = find(id);

            advertisement.Status = "Inactive";
            db.SaveChanges();
        }

        public static Advertisement find(int id)
        {
            return (from adv in db.Advertisements
                    where adv.Id == id
                    select adv).FirstOrDefault();
        }
    }
}
