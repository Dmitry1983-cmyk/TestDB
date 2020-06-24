using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestDB.Presenter.Results
{
    public class RedirectResult:IResult
    {
        private string url;

        public RedirectResult(string url)
        {
            this.url = url;
        }
        public string Url
        {
            get { return url; }
        }
    }
}