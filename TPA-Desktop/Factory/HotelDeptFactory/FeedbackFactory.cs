using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPA_Desktop.Model;

namespace TPA_Desktop.Factory.HotelDeptFactory
{
    class FeedbackFactory
    {

        public static Feedback create(int reservationID, string description, string type)
        {
            Feedback f = new Feedback();
            f.ReservationId = reservationID;
            f.Description = description;
            f.Type = type;

            return f;
        }
    }
}
