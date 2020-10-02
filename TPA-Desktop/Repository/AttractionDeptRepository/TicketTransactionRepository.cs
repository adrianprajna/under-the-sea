using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPA_Desktop.Connection;
using TPA_Desktop.Model;

namespace TPA_Desktop.Repository.AttractionDeptRepository
{
    class TicketTransactionRepository
    {

        private static DatabaseEntities db = Connect.getInstance();

        public static List<TicketTransaction> getAll()
        {
            return db.TicketTransactions.ToList();
        }

        public static void add(TicketTransaction t)
        {
            db.TicketTransactions.Add(t);
            db.SaveChanges();
        }

        public static void update(int id, int qty)
        {
            var t = db.TicketTransactions.Where(ticket => ticket.Id == id).FirstOrDefault();

            t.Quantity = qty;
            t.TotalPrice = 100000 * qty;

            db.SaveChanges();
        }
    }
}
