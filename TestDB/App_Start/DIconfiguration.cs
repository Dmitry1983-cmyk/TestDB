using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestDB.MVC;
using TestDB.MVC.Repository;
using TestDB.Presenter;

namespace TestDB.App_Start
{
    public class DIconfiguration
    {
        public static void SetupDI(IKernel kernel)
        {
            //GuestResponse
            kernel.Bind<IPresenter<VisitorsRespounse>>().To<RSVPPresenter>();
            kernel.Bind<IPresenter<IEnumerable<VisitorsRespounse>>>().To<RSVPPresenter>();
            kernel.Bind<IRepository>().To<MemoryRepository>().InSingletonScope();
            //GuestResponse                 END
        }
    }
}