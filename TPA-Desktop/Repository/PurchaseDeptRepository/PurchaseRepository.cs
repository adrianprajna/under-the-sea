using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPA_Desktop.Connection;
using TPA_Desktop.Model;

namespace TPA_Desktop.Repository.PurchaseDeptRepository
{
    class PurchaseRepository
    {

        private static DatabaseEntities db = Connect.getInstance();

        public static List<PurchaseInformation> getAll()
        {
            return db.PurchaseInformations.ToList();
        }

        public static void add(PurchaseInformation p)
        {
            db.PurchaseInformations.Add(p);
            db.SaveChanges();
        }


    }
}
