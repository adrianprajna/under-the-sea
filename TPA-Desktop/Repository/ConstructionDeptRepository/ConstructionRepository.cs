using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPA_Desktop.Connection;
using TPA_Desktop.Model;

namespace TPA_Desktop.Repository.ConstructionDeptRepository
{
    class ConstructionRepository
    {
        private static DatabaseEntities db = Connect.getInstance();

        public static List<Construction> getAllConstruction()
        {
            return db.Constructions.ToList();
        }


        public static dynamic getAll()
        {
            return (from c in db.Constructions
                    join i in db.Ideas
                    on c.IdeaID equals i.Id
                    select new { c.Id, title = i.Tittle, information = i.Information, c.Status }).ToList();
        }

        

        public static void add(Construction c)
        {
            db.Constructions.Add(c);
            db.SaveChanges();
        }

        public static void start(Construction c)
        {
            c.Status = "In progress of constructing";

            db.SaveChanges();
        }

        public static void finish(Construction c)
        {
            c.Status = "Finish constructing";

            db.SaveChanges();
        }

        public static Construction find(int id)
        {
            return (from c in db.Constructions
                    where c.Id == id
                    select c).FirstOrDefault();
        }

    }
}
