
namespace TestDB.Presenter.Results
{
    public class RedirectRegistation:IRegistratorResult
    {
        private string url;

        public RedirectRegistation(string url)
        {
            this.url = url;
        }
        public string Url
        {
            get { return url; }
        }
    }
}