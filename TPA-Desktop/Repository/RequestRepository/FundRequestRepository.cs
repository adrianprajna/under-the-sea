using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPA_Desktop.Connection;
using TPA_Desktop.Model;

namespace TPA_Desktop.Repository.RequestRepository
{
    class FundRequestRepository
    {
        private static DatabaseEntities db = Connect.getInstance();

        public static void add(FundRequest f)
        {
            db.FundRequests.Add(f);
            db.SaveChanges();
        }

        public static List<FundRequest> getAll()
        {
            return db.FundRequests.ToList();
        }

        public static void update(int id, string note, string status)
        {
            var x = find(id);

            x.Status = status;
            x.Note = note;
            x.Date = DateTime.Now;
            db.SaveChanges();
        }

        public static FundRequest find(int id)
        {
            return (from req in db.FundRequests
                    where req.Id == id
                    select req).FirstOrDefault();
        }
    }
}
