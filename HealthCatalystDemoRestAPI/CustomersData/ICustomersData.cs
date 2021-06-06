using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthCatalystDemoRestAPI.Models;

namespace HealthCatalystDemoRestAPI.CustomersData
{
    public interface ICustomersData
    {
        List<Customer> GetCustomers();

        Customer GetCustomer(Guid id);

        Customer AddCustomer(Customer customer);

        void DeleteCustomer(Customer customer);

        Customer EditCustomer(Customer customer);
    }
}
