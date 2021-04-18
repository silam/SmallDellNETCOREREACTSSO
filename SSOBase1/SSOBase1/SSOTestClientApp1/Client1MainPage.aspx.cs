using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace SSOTestClientApp1
{
    public partial class Client1MainPage : System.Web.UI.Page
    {
        string struser;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["UserId"] == null && Session["FromClient1Login"] == null)
                FormsAuthentication.RedirectToLoginPage();
            else
            {
                if (Session["FromClient1Login"] != null)
                {
                    struser = Session["Userid"].ToString();
                    lblMessage.Text = "Welcome " + struser + System.Environment.NewLine + " This Login is from Client 1 login";
                }
                else if (Request.QueryString["IsAuthenticatedBySSO"] != null)
                {
                    struser = Request.QueryString["UserId"].ToString();
                    SSOClient1DBDataContext db = new SSOClient1DBDataContext();
                    var _appSpecificUserName = (from u in db.Client1Maps
                                                where u.MainAppUserId == struser
                                                select u.C1AppUserId).ToList();
                    struser = _appSpecificUserName[0].ToString();
                    lblMessage.Text = "Welcome " + struser + System.Environment.NewLine + " This Login is from SSO";
                }
            }
        }
    }
}