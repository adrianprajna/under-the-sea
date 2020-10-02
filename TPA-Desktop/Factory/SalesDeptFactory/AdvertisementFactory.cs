using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPA_Desktop.Model;

namespace TPA_Desktop.Factory.SalesDeptFactory
{
    class AdvertisementFactory
    {

        public static Advertisement create(string title, string description)
        {
            Advertisement a = new Advertisement();
            a.Title = title;
            a.Description = description;
            a.Status = "Active";

            return a;
        }
    }
}
