using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPA_Desktop.Connection;
using TPA_Desktop.Model;

namespace TPA_Desktop.Repository.HRDDeptRepository
{
    class DepartmentRepository
    {

        private static DatabaseEntities db = Connect.getInstance();

        public static Department find(string name)
        {
            return (from d in db.Departments
                    where d.Name == name
                    select d).FirstOrDefault();
        }

        public static Department find(int id)
        {
            return db.Departments.Where(d => d.Id == id).FirstOrDefault();
        }

    }
}
