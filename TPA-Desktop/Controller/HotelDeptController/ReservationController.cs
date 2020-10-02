using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPA_Desktop.Factory.HotelDeptFactory;
using TPA_Desktop.Model;
using TPA_Desktop.Repository.HotelDeptRepository;
using TPA_Desktop.View.HotelDeptView;

namespace TPA_Desktop.Controller.HotelDeptController
{
    class ReservationController
    {
        private static ReservationController controller;

        private ReservationController()
        {

        }

        public static ReservationController getInstance()
        {
            if (controller == null)
                controller = new ReservationController();

            return controller;
        }

        public List<Reservation> getAll()
        {
            return ReservationRepository.getAll();
        }

        public bool add(int employeeId, int visitorId, int roomId, string checkIn, int night, int totalPrice)
        {
            Reservation r = ReservationFactory.create(employeeId, visitorId, roomId, checkIn, night, totalPrice);

            var room = RoomController.getInstance().find(roomId);
            if (room.Status == "Booked") return false;

            RoomController.getInstance().update(roomId);
            ReservationRepository.add(r);
            return true;
        }

        public Reservation find(int id)
        {
            return ReservationRepository.find(id);
        }

        public void update(int id, string status, Room room)
        {
            ReservationRepository.update(id, status, room);
        }

        public void update(int id, int night)
        {
            ReservationRepository.update(id, night);
        }

        public void remove(int id, Room r)
        {
            ReservationRepository.remove(id, r);
        }

        public AddReservation openAddReservation(int employeeID, int visitorID)
        {
            return new AddReservation(employeeID, visitorID);
        }
    }
}
