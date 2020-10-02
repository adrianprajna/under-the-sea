using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPA_Desktop.Factory.SalesDeptFactory;
using TPA_Desktop.Model;
using TPA_Desktop.Repository.SalesDeptRepository;
using TPA_Desktop.View.SalesDeptView;

namespace TPA_Desktop.Controller.SalesDeptController
{
    class AdvertisementController
    {

        private static AdvertisementController con;

        private AdvertisementController()
        {

        }

       

        public static AdvertisementController getInstance()
        {
            if (con == null)
                con = new AdvertisementController();

            return con;
        }

        public List<Advertisement> getAll()
        {
            return AdvertisementRepository.getAll();
        }

        public void add(string title, string description)
        {
            Advertisement a = AdvertisementFactory.create(title, description);

            AdvertisementRepository.add(a);
        }

        public bool update(int id, string title, string description)
        {
            var advertisement = AdvertisementRepository.find(id);

            if (advertisement.Status == "Inactive") return false;

            AdvertisementRepository.update(id, title, description);
            return true;
        }

        public bool remove(int id)
        {
            var advertisement = AdvertisementRepository.find(id);

            if (advertisement.Status == "Inactive") return false;

            AdvertisementRepository.remove(id);
            return true;
        }

        public UpdatePage viewUpdate(int id)
        {
            return new UpdatePage(id);
        }
   }

}
