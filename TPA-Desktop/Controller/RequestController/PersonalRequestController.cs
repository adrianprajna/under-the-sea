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
    class PersonalRequestController
    {
        private static PersonalRequestController con;

        private PersonalRequestController()
        {

        }

        public static PersonalRequestController getInstance()
        {
            if (con == null)
                con = new PersonalRequestController();

            return con;
        }

        public void add(int employeeID, string title, string description, string type)
        {
            PersonalRequest p = PersonalRequestFactory.create(employeeID, title, description, type);

            PersonalRequestRepository.add(p);
        }

        public List<PersonalRequest> getAll()
        {
            return PersonalRequestRepository.getAll();
        }

        public void update(int id, string note, string status)
        {
            PersonalRequestRepository.update(id, note, status);
        }


    }
}
