using System.Web.Mvc;

namespace RichBankDemoApp.Areas.AccountInfo
{
    public class AccountInfoAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "AccountInfo";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "AccountInfo_default",
                "AccountInfo/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                namespaces: new[] {"RichBankDemoApp.Areas.AccountInfo.Controllers"}
            );
        }
    }
}