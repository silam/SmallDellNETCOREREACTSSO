using RichBank.Services.AccountService;
using RichBank.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RichBankDemoApp.Areas.AccountInfo.Controllers
{
    public class AccountInformationController : Controller
    {
        private IAccountService accountService;
        public AccountInformationController(IAccountService accountService)
        {
            this.accountService = accountService;
        }
        public ActionResult Index()
        {
            //For demo purpose hardcoded CustomerId is passed
            List<Account> allTrainings = accountService.GetAllAccountInfo(111);
            return View(allTrainings);
        }
        public ActionResult GetAccountDetail(string accountNumber)
        {
            Account accountdetail = accountService.GetAccountDetail(Convert.ToInt32(accountNumber));
            return Json(accountdetail);
        }
    }
}