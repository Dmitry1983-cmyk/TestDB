using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDB.MVC.Repository
{
    interface IRegistrationRepository
    {
        IEnumerable<RegistrationRespounse> GetAllResponses();
        void AddResponse(RegistrationRespounse response);
    }
}
