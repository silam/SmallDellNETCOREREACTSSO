using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SSOTestClientApp1
{
    public partial class Client1Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void  LoginControl_Authenticate1(object sender, AuthenticateEventArgs e)
        {
            SSOClient1DBDataContext db = new SSOClient1DBDataContext();
            var psw = (from c in db.Client1Credentails
                       where c.UserId == LoginControl.UserName
                       select c.Password).ToList();
            string strPsw = psw[0].ToString();
            Session["UserId"] = LoginControl.UserName;
            Session["FromClient1Login"] = "1";
            if(strPsw == LoginControl.Password.ToString())
                Response.Redirect("~/Client1MainPage.aspx");
        }
    }
}