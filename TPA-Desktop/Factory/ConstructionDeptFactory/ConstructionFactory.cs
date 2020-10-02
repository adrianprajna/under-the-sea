using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPA_Desktop.Model;

namespace TPA_Desktop.Factory.ConstructionDeptFactory
{
    class ConstructionFactory
    {

        public static Construction create(int ideaID)
        {
            Construction c = new Construction();
            c.IdeaID = ideaID;
            c.Status = "Waiting for constructing";

            return c;
        }

    }
}
