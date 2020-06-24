using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestDB.Presenter.Results
{
    public class RegistrationResult<T>:IRegistratorResult
    {
        private T dataItem;

        public RegistrationResult(T dataItem)
        {
            this.dataItem = dataItem;
        }
        public T DataItem
        {
            get { return dataItem; }
        }
    }
}