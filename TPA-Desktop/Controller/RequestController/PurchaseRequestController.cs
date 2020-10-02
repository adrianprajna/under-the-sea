using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPA_Desktop.Factory.RequestFactory;
using TPA_Desktop.Model;
using TPA_Desktop.Repository.RequestRepository;

namespace TPA_Desktop.Controller.RequestController
{
    class PurchaseRequestController
    {
        private static PurchaseRequestController con;

        private PurchaseRequestController()
        {

        }

        public static PurchaseRequestController getInstance()
        {
            if (con == null)
                con = new PurchaseRequestController();

            return con;
        }

        public void add(int departmentID, string information)
        {
            PurchaseRequest p = PurchaseRequestFactory.create(departmentID, information);

            PurchaseRequestRepository.add(p);
        }

        public List<PurchaseRequest> getAll()
        {
            return PurchaseRequestRepository.getAll();
        }

        public PurchaseRequest find(int id)
        {
            return PurchaseRequestRepository.find(id);
        }

        public void update(int id)
        {
            PurchaseRequestRepository.update(id);
        }

        public void notify(int id, string status, string note)
        {
            PurchaseRequestRepository.notify(id, status, note);
        }
    }
}
