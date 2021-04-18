using RichBank.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichBank.Services.CustomerService
{
    public class CustomerService : ICustomerService
    {
        public Customer GetCustomer()
        {
            return new Customer { CustomerId =111, CustomerName = "Snesh" };
        }
    }
}
