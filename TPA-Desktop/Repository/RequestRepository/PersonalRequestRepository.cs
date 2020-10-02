using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPA_Desktop.Connection;
using TPA_Desktop.Model;

namespace TPA_Desktop.Repository.RequestRepository
{
    class PersonalRequestRepository
    {

        private static DatabaseEntities db = Connect.getInstance();

        public static void add(PersonalRequest p)
        {
            db.PersonalRequests.Add(p);
            db.SaveChanges();
        }

        public static List<PersonalRequest> getAll()
        {
            return db.PersonalRequests.ToList();
        }

        public static void update(int id, string note, string status)
        {
            var x = (from p in db.PersonalRequests
                     where p.Id == id
                     select p).FirstOrDefault();

            x.Note = note;
            x.Status = status;

            db.SaveChanges();
        }
    }
}
