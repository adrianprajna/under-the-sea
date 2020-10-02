using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPA_Desktop.Connection;
using TPA_Desktop.Model;

namespace TPA_Desktop.Repository.HotelDeptRepository
{
    class VisitorRepository
    {

        private static DatabaseEntities db = Connect.getInstance();

        public static List<Visitor> getAll()
        {
            return db.Visitors.ToList();
        }

        public static void add(Visitor v)
        {
            db.Visitors.Add(v);
            db.SaveChanges();
        }

        public static void update(int id, string name, DateTime dob, string email, string phone)
        {

            var visitor = db.Visitors.Where(v => v.Id == id).FirstOrDefault();

            visitor.Name = name;
            visitor.DOB = dob;
            visitor.Email = email;
            visitor.phoneNumber = phone;

            db.SaveChanges();
        }

        public static void remove(int id)
        {
            var visitor = db.Visitors.Where(v => v.Id == id).FirstOrDefault();

            visitor.Status = "Inactive";

            db.SaveChanges();
        }
    }
}
