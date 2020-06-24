using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestDB.MVC.Repository
{
    public class RegistrationRepository : IRegistrationRepository
    {
        private List<RegistrationRespounse> responses = new List<RegistrationRespounse>();
        public void AddResponse(RegistrationRespounse response)
        {
            responses.Add(response);
        }

        IEnumerable<RegistrationRespounse> IRegistrationRepository.GetAllResponses()
        {
            return responses;
        }
    }
}