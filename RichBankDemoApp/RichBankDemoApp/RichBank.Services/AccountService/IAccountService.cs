using RichBank.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichBank.Services.AccountService
{
    public interface IAccountService
    {
        List<Account> GetAllAccountInfo(int customerId);
        Account GetAccountDetail(int accountNumber);
        List<int> GetAccountNumber(int customerId);
        double GetCurrentBalance(double accountNumber);
    }
}
