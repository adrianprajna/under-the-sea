using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPA_Desktop.Model;

namespace TPA_Desktop.Factory.RequestFactory
{
    class PersonalRequestFactory
    {

        public static PersonalRequest create(int employeeID, string title, string description,
                                            string type)
        {
            PersonalRequest p = new PersonalRequest();
            p.EmployeeID = employeeID;
            p.Title = title;
            p.Description = description;
            p.Type = type;
            p.Note = "";
            p.Status = "Pending";
            p.Date = DateTime.Now;

            return p;
        }
    }
}
