using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestDB.MVC;
using TestDB.MVC.Repository;
using TestDB.Presenter.Results;

namespace TestDB.Presenter
{
    public class RSVPPresenter : IPresenter<VisitorsRespounse>, IPresenter<IEnumerable<VisitorsRespounse>>
    {
        public IRepository repository { get; set; }

        IResult IPresenter<VisitorsRespounse>.GetResult()
        {
            return new DataResult<VisitorsRespounse>(new VisitorsRespounse());
        }

        IResult IPresenter<VisitorsRespounse>.GetResult(VisitorsRespounse requestData)
        {
            repository.AddResponse(requestData);
            if (requestData.WillAttend.Value)
                return new RedirectResult(@"/HTML/RegUserDone.html");
            else
                return new RedirectResult(@"/HTML/wrongDataAutorization.html");
        }

        IResult IPresenter<IEnumerable<VisitorsRespounse>>.GetResult()
        {
            throw new NotImplementedException();
        }

        IResult IPresenter<IEnumerable<VisitorsRespounse>>.GetResult(IEnumerable<VisitorsRespounse> requestData)
        {
            return new DataResult<IEnumerable<VisitorsRespounse>>(repository.GetAllResponses());
        }
    }
}