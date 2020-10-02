using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPA_Desktop.Connection;
using TPA_Desktop.Model;

namespace TPA_Desktop.Repository.HotelDeptRepository
{
    class FeedbackRepository
    {

        private static DatabaseEntities db = Connect.getInstance();

        public static List<Feedback> getAll()
        {
            return db.Feedbacks.ToList();
        }

        public static void add(Feedback f)
        {
            db.Feedbacks.Add(f);
            db.SaveChanges();
        }
    }
}
