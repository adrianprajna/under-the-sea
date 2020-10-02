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
    class FeedbackController
    {
        private static FeedbackController controller;

        private FeedbackController()
        {

        }

        public static FeedbackController getInstance()
        {
            if (controller == null)
                controller = new FeedbackController();

            return controller;
        }

        public List<Feedback> getAll()
        {
            return FeedbackRepository.getAll();
        }

        public void add(int reservationID, string description, string type)
        {
            Feedback f = FeedbackFactory.create(reservationID, description, type);

            FeedbackRepository.add(f);
        }

        public FeedbackPage openFeedback(int reservationID)
        {
            return new FeedbackPage(reservationID);
        }


    }
}
