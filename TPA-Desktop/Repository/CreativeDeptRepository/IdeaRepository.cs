using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPA_Desktop.Connection;
using TPA_Desktop.Model;

namespace TPA_Desktop.Repository
{
    class IdeaRepository
    {

        private static DatabaseEntities db = Connect.getInstance();

        public static bool insert(Idea idea)
        {
            db.Ideas.Add(idea);
            db.SaveChanges();

            return true;
        }

        public static void remove(int id)
        {
            var idea = find(id);

            idea.Status = "Sent to Construction";
            db.SaveChanges();
        }

        public static Idea find(int id)
        {
            return (from idea in db.Ideas
                    where idea.Id == id
                    select idea).FirstOrDefault();
        }

        public static void update(int id, string note, string status)
        {
            var idea = find(id);

            idea.Status = status;
            idea.Note = note;

            db.SaveChanges();
        }

        public static List<Idea> getAll()
        {
            return db.Ideas.ToList();
        }


    }
}
