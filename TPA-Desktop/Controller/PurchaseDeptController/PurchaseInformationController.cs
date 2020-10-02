using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPA_Desktop.Factory.PurchaseDeptFactory;
using TPA_Desktop.Model;
using TPA_Desktop.Repository.PurchaseDeptRepository;

namespace TPA_Desktop.Controller.PurchaseDeptController
{
    class PurchaseInformationController
    {
        private static PurchaseInformationController con;

        private PurchaseInformationController()
        {

        }

        public List<PurchaseInformation> PurchaseInformationRepository { get; private set; }

        public static PurchaseInformationController getInstance()
        {
            if (con == null)
                con = new PurchaseInformationController();

            return con;
        }

        public List<PurchaseInformation> getAll()
        {
            return PurchaseRepository.getAll();
        }

        public void add(int employeeID, string information)
        {
            PurchaseInformation p = PurchaseInformationFactory.create(employeeID, information);

            PurchaseRepository.add(p);
        }

    }
}
