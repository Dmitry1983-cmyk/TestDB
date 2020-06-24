using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDB.Presenter.Results;

namespace TestDB.Presenter
{
    interface IRegistrator<T>
    {
        IRegistratorResult GetResult();
        IRegistratorResult GetResult(T requestData);
    }
}
