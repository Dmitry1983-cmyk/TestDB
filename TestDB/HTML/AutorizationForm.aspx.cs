using System;
using System.Web.ModelBinding;
using TestDB.MVC;

namespace TestDB.HTML
{
    public partial class AutorizationForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(IsPostBack)
            {
                Model rst = new Model();
                if (TryUpdateModel(rst, new FormValueProvider(ModelBindingExecutionContext)))
                {
                    Controller.GetController().AddModels(rst);
                    Response.Redirect("RegForm.aspx");
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if(IsPostBack)
            {
                Model rst = new Model();
                if (TryUpdateModel(rst, new FormValueProvider(ModelBindingExecutionContext)))
                {
                    Controller.GetController().AddModels(rst);
                    if (login.Value != "" && pass.Value != "")
                    {
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