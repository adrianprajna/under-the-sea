using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPA_Desktop.Connection;
using TPA_Desktop.Model;

namespace TPA_Desktop.Repository.HRDDeptRepository
{
    class WorkPerformanceRepository
    {

        private static DatabaseEntities db = Connect.getInstance();

        public static List<WorkPerformance> getAll()
        {
            return db.WorkPerformances.ToList();
        }

        public static void add(WorkPerformance w)
        {
            db.WorkPerformances.Add(w);
            db.SaveChanges();
        }

        public static void update(int id, string performance)
        {
            var work = (from w in db.WorkPerformances
                        where w.Id == id
                        select w).FirstOrDefault();

            work.PerformanceDetail = performance;

            db.SaveChanges();
        }

        public static void remove(int id)
        {
            var work = (from w in db.WorkPerformances
                        where w.Id == id
                        select w).FirstOrDefault();

            work.Status = "Inactive";

            db.SaveChanges();
        }
    }
}
