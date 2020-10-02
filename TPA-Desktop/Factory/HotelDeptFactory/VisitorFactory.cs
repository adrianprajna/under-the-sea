using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPA_Desktop.Model;

namespace TPA_Desktop.Factory.HotelDeptFactory
{
    class VisitorFactory
    {


        public static Visitor create(string name, DateTime dob, string email, string phoneNumber)
        {
            Visitor v = new Visitor();
            v.Name = name;
            v.DOB = dob;
            v.Email = email;
            v.phoneNumber = phoneNumber;
            v.Status = "Active";

            return v;
        }
    }
}
