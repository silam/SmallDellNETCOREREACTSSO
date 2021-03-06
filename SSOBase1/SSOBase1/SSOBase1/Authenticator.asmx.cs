using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;

namespace SSOBase1
{    
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    
    public class Authenticator : System.Web.Services.WebService
    {
        string _userId;
        public Authenticator(string UserId)
        {
            _userId = UserId;
        }

        [WebMethod]
        public bool AuthenticateUser(string password)
        {            
            SSODBDataContext db = new SSODBDataContext();
            var psw = (from c in db.MainAppCredentials
                      where c.Userid == _userId
                      select c.Password).ToList();
            string strPsw = psw[0].ToString();
            return strPsw == password ? true : false;                    
        }

        [WebMethod]
        public DataTable GetAppAccessDetails()
        {
            SSODBDataContext db = new SSODBDataContext();
            var results=(from a in db.Apps
                             join ua in db.UserAppMaps on a.AppId equals ua.AppId
                             where ua.MUserId == _userId
                             select a).ToList();
            
            DataTable dtRes=new DataTable();
            dtRes.Columns.Add("ApplicationName");        
            dtRes.Columns.Add("ApplicationURL");
            foreach(var c in results)
            {
                DataRow dr=dtRes.NewRow();
                dr[0]=c.AppName;
                dr[1]=c.AppUrl;
                dtRes.Rows.Add(dr);
            }
            return dtRes;
        }

        [WebMethod]
        public string AuthenticateClientUrl(string clientUrl)
        {
            return clientUrl + "?UserId=" + _userId + "&IsAuthenticatedBySSO=1";
        }

    }
}
