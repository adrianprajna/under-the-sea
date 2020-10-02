using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPA_Desktop.Factory.AttractionDeptFactory;
using TPA_Desktop.Model;
using TPA_Desktop.Repository.AttractionDeptRepository;

namespace TPA_Desktop.Controller.AttractionDeptController
{
    class TicketController
    {

        private static TicketController con;

        private TicketController()
        {

        }

        public static TicketController getInstance()
        {
            if (con == null)
                con = new TicketController();

            return con;
        }

        public Ticket find(int id)
        {
            return TicketRepository.find(id);
        }

        public List<Ticket> getAll()
        {
            return TicketRepository.getAll();
        }

        public void add(Ticket t)
        {
            TicketRepository.add(t);
        }

        public Ticket createTicket()
        {
            return TicketFactory.create();
        }
    }
}
