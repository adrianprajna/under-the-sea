using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPA_Desktop.Factory.HotelDeptFactory;
using TPA_Desktop.Model;
using TPA_Desktop.Repository.HotelDeptRepository;

namespace TPA_Desktop.Controller.HotelDeptController
{
    class VisitorController
    {
        private static VisitorController controller;

        private VisitorController()
        {

        }

        public static VisitorController getInstance()
        {
            if (controller == null)
                controller = new VisitorController();

            return controller;
        }

        public List<Visitor> getAll()
        {
            return VisitorRepository.getAll();
        }

        public void add(string name, DateTime dob, string email, string phoneNumber)
        {
            Visitor v = VisitorFactory.create(name, dob, email, phoneNumber);

            VisitorRepository.add(v);
        }

        public void update(int id, string name, DateTime dob, string email, string phoneNumber)
        {
            VisitorRepository.update(id, name, dob, email, phoneNumber);
        }

        public void remove(int id)
        {
            VisitorRepository.remove(id);
        }
    }
}
