using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPA_Desktop.Model;

namespace TPA_Desktop.Connection
{
    class Connect
    {
        private static DatabaseEntities db;

        private Connect()
        {

        }

        public static DatabaseEntities getInstance()
        {
            if (db == null)
                db = new DatabaseEntities();

            return db;
        }


    }
}
