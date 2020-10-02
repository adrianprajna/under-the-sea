using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPA_Desktop.Model;

namespace TPA_Desktop.Factory.AttractionDeptFactory
{
    class TicketFactory
    {

        public static Ticket create()
        {
            Ticket t = new Ticket();
            t.Valid_Date = DateTime.Today;

            return t;
        }
    }
}
