using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPA_Desktop.Model;

namespace TPA_Desktop.Factory
{
    class IdeaFactory
    {
        public static Idea create(string title, string information)
        {
            Idea idea = new Idea();
            idea.Tittle = title;
            idea.Information = information;
            idea.Status = "Pending";
            idea.Date = DateTime.Now;

            return idea;
        }

    }
}
