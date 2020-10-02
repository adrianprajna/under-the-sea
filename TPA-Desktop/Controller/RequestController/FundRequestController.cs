using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPA_Desktop.Factory.RequestFactory;
using TPA_Desktop.Model;
using TPA_Desktop.Repository.RequestRepository;
using TPA_Desktop.View.FinanceDeptView;

namespace TPA_Desktop.Controller.RequestController
{
    class FundRequestController
    {
        private static FundRequestController con;

        private FundRequestController()
        {

        }

        public static FundRequestController getInstance()
        {
            if (con == null)
                con = new FundRequestController();

            return con;
        }


        public List<FundRequest> getAll()
        {
            return FundRequestRepository.getAll();
        }

        public void add(int departmentId, string information, int money)
        {
            FundRequest f = FundRequestFactory.create(departmentId, information, money);

            FundRequestRepository.add(f);
        }

        public FundRequest find(int id)
        {
            return FundRequestRepository.find(id);
        }

        public void update(int id, string note, string status)
        {
            FundRequestRepository.update(id, note, status);
        }

        public ManagePage viewManage(int id)
        {
            return new ManagePage(id);
        }
    }
}
