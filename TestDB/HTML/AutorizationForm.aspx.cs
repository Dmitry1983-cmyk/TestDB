using System;
using System.Data.SqlClient;
using System.Web.ModelBinding;
using TestDB.MVC;

namespace TestDB.HTML
{
    public partial class AutorizationForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                Model rst = new Model();
                if (TryUpdateModel(rst, new FormValueProvider(ModelBindingExecutionContext)))
                {
                    Controller.GetController().AddModels(rst);
                    if (rst.Login != null && rst.Password != null)
                    {
                        using (RegistrationFormEntities reg = new RegistrationFormEntities())
                        {

                            foreach (var user in reg.LoginTable)
                            {
                                string html = String.Format("<tr><td>{0}</td></tr>",user.Login);Response.Write(html);
                            }
                        }
                        Response.Redirect("dataUser.html");
                    }
                    else
                    {
                        Response.Redirect("wrongDataAutorization.html");
                    }
                }
            }
        }
    }
}