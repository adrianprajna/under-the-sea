using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPA_Desktop.Factory.ConstructionDeptFactory;
using TPA_Desktop.Model;
using TPA_Desktop.Repository.ConstructionDeptRepository;

namespace TPA_Desktop.Controller.ConstructionDeptController
{
    class ConstructionController
    {

        private static ConstructionController con;

        private ConstructionController()
        {

        }

        public static ConstructionController getInstance()
        {
            if (con == null)
                con = new ConstructionController();

            return con;
        }

        public List<Construction> getAll()
        {
            return ConstructionRepository.getAllConstruction();
        }

        public bool start(int id)
        {
            var construction = ConstructionRepository.find(id);

            if (construction.Status != "Waiting for constructing") return false;

            ConstructionRepository.start(construction);
            return true;
        }

        public bool finish(int id)
        {
            var construction = ConstructionRepository.find(id);

            if (construction.Status != "In progress of constructing")
                    return false;

            ConstructionRepository.finish(construction);
            return true;
        }

        public bool add(int ideaID)
        {
            var lists = ConstructionRepository.getAllConstruction();
            foreach(Construction c in lists)
            {
                if (c.IdeaID == ideaID) return false;
            }

            var construction = ConstructionFactory.create(ideaID);

            ConstructionRepository.add(construction);
            return true;
        }

    }
}
