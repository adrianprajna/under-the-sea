using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPA_Desktop.Controller.ConstructionDeptController;
using TPA_Desktop.Factory;
using TPA_Desktop.Model;
using TPA_Desktop.Repository;

namespace TPA_Desktop.Controller
{
    class IdeaController
    {
        private static IdeaController controller;

        private IdeaController()
        {

        }

        public static IdeaController getInstance()
        {
            if (controller == null)
                controller = new IdeaController();

            return controller;
        }

        public List<Idea> getAll()
        {
            return IdeaRepository.getAll();
        }

        public bool insert(string title, string information)
        {
            Idea idea = IdeaFactory.create(title, information);

            return IdeaRepository.insert(idea);
        }

        public void update(int id, string note, string status)
        {
            IdeaRepository.update(id, note, status);
        }

        public int send(int id)
        {
            var idea = IdeaRepository.find(id);

            if (idea.Status == "Accepted")
            {
                if (ConstructionController.getInstance().add(id))
                {
                    IdeaRepository.remove(id);
                    return 1;
                }

                return 0;
            }

            return -1;
        }

    }
}
