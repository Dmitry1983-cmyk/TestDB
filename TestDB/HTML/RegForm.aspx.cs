using System;
using System.Web.ModelBinding;
using TestDB.MVC;

namespace TestDB.HTML
{
    public partial class RegForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                Model rst = new Model();
                if (TryUpdateModel(rst, new FormValueProvider(ModelBindingExecutionContext)))
                {
                    Controller.GetController().AddModels(rst);
                    if (rst.Name != null && rst.PhoneNumber != null && rst.Email != null && rst.Login != null && rst.Password != null)
                    {
                        using (RegistrationFormEntities reg = new RegistrationFormEntities())
                        {
                            reg.UserTable.Add(new UserTable() { FirstName = rst.Name, PhoneNumber = rst.PhoneNumber, E_mail = rst.Email});
                            reg.SaveChanges();
                            reg.LoginTable.Add(new LoginTable() { Login = rst.Login });
                            reg.SaveChanges();
                            reg.PasswordTable.Add(new PasswordTable() { Password = rst.Password });
                            reg.SaveChanges();
                        }
                        Response.Redirect("RegUserDone.html");
                    }
                    else
                    {
                        Response.Redirect("wrongData.html");
                    }
                }
            }
        }
    }
}