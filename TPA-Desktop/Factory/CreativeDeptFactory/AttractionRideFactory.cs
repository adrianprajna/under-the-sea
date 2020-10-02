using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPA_Desktop.Model;

namespace TPA_Desktop.Factory.CreativeDeptFactory
{
    class AttractionRideFactory
    {
        public static AttractionRide create(string name, string description, string type)
        {
            AttractionRide a = new AttractionRide();
            a.Name = name;
            a.Description = description;
            a.Type = type;
            a.Status = "Active";

            return a;
        }
    }
}
