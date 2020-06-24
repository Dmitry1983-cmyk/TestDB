using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestDB.Presenter.Results
{
    public class DataResult<T>:IResult
    {
        private T dataItem;

        public DataResult(T dataItem)
        {
            this.dataItem = dataItem;
        }
        public T DataItem
        {
            get { return dataItem; }
        }
    }
}