using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPA_Desktop.Model;

namespace TPA_Desktop.Factory.MaintenenceFactory
{
    class MaintenenceFactory
    {

        public static Maintenence create(int attr_id, string information)
        {
            Maintenence m = new Maintenence();
            m.AttractionRideID = attr_id;
            m.Information = information;
            m.Status = "Under Maintenence";

            return m;
        }

    }
}
