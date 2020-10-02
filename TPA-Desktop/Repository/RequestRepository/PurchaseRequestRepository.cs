using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPA_Desktop.Connection;
using TPA_Desktop.Controller.RequestController;
using TPA_Desktop.Model;

namespace TPA_Desktop.Repository.RequestRepository
{
    class PurchaseRequestRepository
    {
        private static DatabaseEntities db = Connect.getInstance();

        public static void add(PurchaseRequest p)
        {
            db.PurchaseRequests.Add(p);
            db.SaveChanges();
        }

        public static List<PurchaseRequest> getAll()
        {
            return db.PurchaseRequests.ToList();
        
        }

        public static void update(int id)
        {
            var a = find(id);

            a.Status = "Sent";
            db.SaveChanges();
        }

        public static void notify(int id, string status, string note)
        {
            var a = find(id);

            a.Status = status;
            a.Note = note;
            a.Date = DateTime.Now;

            db.SaveChanges();
        }


        public static PurchaseRequest find(int id)
        {
            return (from purchase in db.PurchaseRequests
                                 where purchase.Id == id
                                 select purchase).FirstOrDefault();
        }

    }
}
