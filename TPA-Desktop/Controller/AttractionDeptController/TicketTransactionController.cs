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
    class TicketTransactionController
    {

        private static TicketTransactionController con;

        private TicketTransactionController()
        {

        }

        public static TicketTransactionController getInstance()
        {
            if (con == null)
                con = new TicketTransactionController();

            return con;
        }

        public void add(int employeeId, int quantity)
        {
            TicketTransaction t = TicketTransactionFactory.create(employeeId, quantity);

            TicketTransactionRepository.add(t);
        }

        public void update(int id, int qty)
        {
            TicketTransactionRepository.update(id, qty);
        }

        public List<TicketTransaction> getAll()
        {
            return TicketTransactionRepository.getAll();
        }
    }
}
