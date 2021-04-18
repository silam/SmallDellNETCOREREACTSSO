using RichBank.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichBank.Services.FundTransferService
{
  public interface IFundTransferService
    {
      bool SaveWithinCustomerAccountTransaction(Transaction transaction);

      List<TransactionType> GetFundTransferTypes();

      double GetCurrentBalanceAfterTransfer(Transaction accountInfo);
     
    }
}
