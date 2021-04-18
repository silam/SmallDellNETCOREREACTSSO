using System.Web.Mvc;

namespace RichBankDemoApp.Areas.FundTransfer
{
    public class FundTransferAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "FundTransfer";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "FundTransfer_default",
                "FundTransfer/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                namespaces: new[] {"RichBankDemoApp.Areas.FundTransfer.Controllers" }
            );
        }
    }
}