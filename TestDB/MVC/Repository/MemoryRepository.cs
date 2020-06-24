using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestDB.MVC.Repository
{
    public class MemoryRepository: IRepository
    {
        private List<VisitorsRespounse> responses = new List<VisitorsRespounse>();
        public void AddResponse(VisitorsRespounse response)
        {
            responses.Add(response);
        }

        public void AddResponse(RegistrationRespounse requestData)
        {

        }

        public IEnumerable<VisitorsRespounse> GetAllResponses()
        {
            return responses;
        }
    }
}