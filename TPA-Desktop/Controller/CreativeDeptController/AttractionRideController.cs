using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPA_Desktop.Factory.CreativeDeptFactory;
using TPA_Desktop.Model;
using TPA_Desktop.Repository.CreativeDeptRepository;
using TPA_Desktop.View.CreativeDeptView;

namespace TPA_Desktop.Controller.CreativeDeptController
{
    class AttractionRideController
    {

        private static AttractionRideController con;

        private AttractionRideController()
        {

        }

        public static AttractionRideController getInstance()
        {
            if (con == null)
                con = new AttractionRideController();

            return con;
        }

        public List<AttractionRide> getAll()
        {
            return AttractionRideRepository.getAll();
        }

        public bool add(string name, string description, string type)
        {
            AttractionRide a = AttractionRideFactory.create(name, description, type);

            return AttractionRideRepository.add(a);
        }

        public bool update(int id, string name, string description)
        {
            var attr_ride = AttractionRideRepository.find(id);

            if (attr_ride.Status == "Removed") return false;


            AttractionRideRepository.update(id, name, description);
            return true;
        }

        public bool remove(int id)
        {
            var attr_ride = AttractionRideRepository.find(id);

            if (attr_ride.Status == "Inactive") return false;


            AttractionRideRepository.remove(id);
            return true;
        }

        public AttractionRide find(int id)
        {
            return AttractionRideRepository.find(id);
        }

        public void updtMaintenence(int id)
        {
            AttractionRideRepository.updtMaintenence(id);
        }

        public UpdatePage viewUpdate(int id)
        {
            return new UpdatePage(id);
        }
    }
}
