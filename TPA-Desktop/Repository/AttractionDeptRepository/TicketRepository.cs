using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPA_Desktop.Connection;
using TPA_Desktop.Model;

namespace TPA_Desktop.Repository.AttractionDeptRepository
{
    class TicketRepository
    {
        private static DatabaseEntities db = Connect.getInstance();

        public static Ticket find(int id)
        {
            return db.Tickets.Where(t => t.Id == id).FirstOrDefault();
        }

        public static List<Ticket> getAll()
        {
            return db.Tickets.ToList();
        }

        public static void add(Ticket t)
        {
            db.Tickets.Add(t);
            db.SaveChanges();
        }
    }
}
