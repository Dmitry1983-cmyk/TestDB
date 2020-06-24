using TestDB.MVC;
using TestDB.MVC.Repository;
using TestDB.Presenter.Results;

namespace TestDB.Presenter
{
    public class RegistratorPresenter:IPresenter<RegistrationRespounse>
    {
        public IRepository repository { get; set; }
        public IResult GetResult()
        {
            return new DataResult<RegistrationRespounse>(new RegistrationRespounse());
        }

        public IResult GetResult(RegistrationRespounse requestData)
        {
            repository.AddResponse(requestData);
            return new RedirectResult(@"/HTML/RegUserDone.html");
        }
    }
}