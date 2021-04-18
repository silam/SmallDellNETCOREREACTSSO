using RichBank.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichBank.Services.AccountService
{
    public class AccountService : IAccountService
    {
        private List<Account> AccountList { get; set; }
        public AccountService()
        {
            this.AccountList = new List<Account>{
            new Account(){AccountNumber = 214587, AccountType = "Saving", BranchName="Sarjapura", CurrentBalance=10000, MinBalance=500,DateOfOpening = Convert.ToDateTime("01/08/2008"), CustomerId =111 },
            new Account(){AccountNumber = 325689, AccountType = "Salary", BranchName="Sarjapura", CurrentBalance=40000, MinBalance=500,DateOfOpening = Convert.ToDateTime("01/08/2008"), CustomerId =111 },
            new Account(){AccountNumber = 874512, AccountType = "Yuva Savings Account", BranchName="Sarjapura", CurrentBalance=20000, MinBalance=500,DateOfOpening = Convert.ToDateTime("01/08/2008"), CustomerId =111 }
            };
        }

        public List<Account> GetAllAccountInfo(int customerId)
        {
            return AccountList;
        }

        public Account GetAccountDetail(int accountNumber)
        {
          var selectedAccountDetail = AccountList.Where(c => c.AccountNumber == accountNumber).FirstOrDefault();
           return selectedAccountDetail;
        }

        public List<int> GetAccountNumber(int customerId)
        {
            var selectedAccoutNumber = AccountList.Select(c => c.AccountNumber).ToList();
            return selectedAccoutNumber;
        }

        public double GetCurrentBalance(double accountNumber)
        {
            var currentBalance = AccountList.Where(x => x.AccountNumber == accountNumber).Select(x => x.CurrentBalance).FirstOrDefault();
            return currentBalance;
        }
    }
}
