using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using RichBank.Services.CustomerService;
using RichBank.Services.AccountService;
using RichBank.Services.FundTransferService;

namespace RichBankDemoApp
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<ICustomerService, CustomerService>();
            container.RegisterType<IAccountService, AccountService>();
            container.RegisterType<IFundTransferService, FundTransferService>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}