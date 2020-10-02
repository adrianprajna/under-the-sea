using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPA_Desktop.Model;
using TPA_Desktop.Repository.HotelDeptRepository;

namespace TPA_Desktop.Controller.HotelDeptController
{
    class RoomController
    {

        private static RoomController controller;

        private RoomController()
        {

        }

        public static RoomController getInstance()
        {
            if (controller == null)
                controller = new RoomController();

            return controller;
        }

        public List<Room> getAll()
        {
            return RoomRepository.getAll();
        }

        public Room find(int id)
        {
            return RoomRepository.find(id);
        }

        public void update(int id)
        {
            RoomRepository.update(id);
        }
    }
}
