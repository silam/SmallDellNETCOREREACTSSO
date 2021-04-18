using RichBank.Services.AccountService;
using RichBank.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichBank.Services.FundTransferService
{
    public class FundTransferService : IFundTransferService
    {
        private IAccountService accountService;
        public FundTransferService(IAccountService accountService)
        {
            this.accountService = accountService;
        }

        public bool SaveWithinCustomerAccountTransaction(Transaction transaction)
        {
            return true;
        }




        public List<TransactionType> GetFundTransferTypes()
        {
            return Enum.GetValues(typeof(TransactionType)).Cast<TransactionType>().ToList();
        }




        public double GetCurrentBalanceAfterTransfer(Transaction accountInfo)
        {

            var currentBanalce = accountService.GetCurrentBalance(Convert.ToDouble(accountInfo.FromAccount));

            var currentBalanceAfterTransfer = currentBanalce - Convert.ToDouble(accountInfo.TransactionAmount);

            return currentBalanceAfterTransfer;
        }
    }
}
