using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPA_Desktop.Controller.CreativeDeptController;
using TPA_Desktop.Factory.MaintenenceFactory;
using TPA_Desktop.Model;
using TPA_Desktop.Repository.MaintenenceDeptRepository;
using TPA_Desktop.View.MaintenenceDeptView;

namespace TPA_Desktop.Controller.MaintenenceDeptController
{
    class MaintenenceController
    {

        private static MaintenenceController controller;

        private MaintenenceController()
        {

        }

        public static MaintenenceController getInstance()
        {
            if (controller == null)
                controller = new MaintenenceController();

            return controller;
        }

        public List<Maintenence> getAll()
        {
           return MaintenenceRepository.getAll();
        }

        public void add(int attr_rideID, string information)
        {
            Maintenence m = MaintenenceFactory.create(attr_rideID, information);

            AttractionRideController.getInstance().updtMaintenence(attr_rideID);
            MaintenenceRepository.add(m);
        }

        public void update(int id, string information)
        {
            MaintenenceRepository.update(id, information);
        }

        public void remove(int id, int attr_ride)
        {
            MaintenenceRepository.remove(id);
            AttractionRideController.getInstance().updtMaintenence(attr_ride);
        }

        public Maintenence find(int id)
        {
            return MaintenenceRepository.find(id);
        }

        public UpdatePage viewUpdate(int id)
        {
            return new UpdatePage(id);
        }
    }
}
