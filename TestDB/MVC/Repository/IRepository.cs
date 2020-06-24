using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDB.MVC.Repository
{
   public interface IRepository
    {
        IEnumerable<VisitorsRespounse> GetAllResponses();
        void AddResponse(VisitorsRespounse response);
        void AddResponse(RegistrationRespounse requestData);
    }
}
