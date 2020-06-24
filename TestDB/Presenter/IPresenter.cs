using TestDB.Presenter.Results;

namespace TestDB.Presenter
{
   public interface IPresenter<T>
    {
        IResult GetResult();
        IResult GetResult(T requestData);
    }
}
