using RichBank.Services.AccountService;
using RichBank.Services.FundTransferService;
using RichBank.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RichBankDemoApp.Areas.FundTransfer.Controllers
{
    public class FundTransferController : Controller
    {
        //
        // GET: /FundTransfer/FundTransfer/

        private IFundTransferService fundTransferService;
        private IAccountService accountService;
        public FundTransferController(IFundTransferService fundTransferService, IAccountService accountService)
        {
            this.fundTransferService = fundTransferService;
            this.accountService =  accountService;
        }
        public ActionResult Index()
        {
             var fundTransferTyoesList = fundTransferService.GetFundTransferTypes();
             return View(fundTransferTyoesList);
        }

        public ActionResult PerformTransaction()
        {            
            return View();
        }

        public ActionResult GetTransactionType(string selectedTransferType)
        {
            var accountNumberList = accountService.GetAccountNumber(0);

            return Json(accountNumberList);
        }

        public ActionResult GetCurrentBalanceAfterTransfer(Transaction amountTransferInfo)
        {
            var currentBalance = fundTransferService.GetCurrentBalanceAfterTransfer(amountTransferInfo);

            return Json(currentBalance);
        }
	}
}