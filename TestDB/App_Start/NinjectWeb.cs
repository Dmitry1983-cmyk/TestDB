using Microsoft.Web.Infrastructure.DynamicModuleHelper;
using Ninject.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestDB.App_Start
{
    public class NinjectWeb
    {
        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
        }
    }
}