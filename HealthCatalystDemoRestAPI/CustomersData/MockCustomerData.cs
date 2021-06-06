using HealthCatalystDemoRestAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthCatalystDemoRestAPI.CustomersData
{
    public class MockCustomerData : ICustomersData
    {
        private List<Customer> customers = new List<Customer>()
        {
            new Customer()
            {
                Id = Guid.NewGuid(),
                Name = "Vishal Sarvagod"
            },
            new Customer()
            {
                Id = Guid.NewGuid(),
                Name = "Vivek Sarvagod"
            },
        };
        public Customer AddCustomer(Customer customer)
        {
            customer.Id = Guid.NewGuid();
            customers.Add(customer);
            return customer;
        }

        public void DeleteCustomer(Customer customer)
        {
            customers.Remove(customer);
        }

        public Customer EditCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomer(Guid id)
        {
            return customers.SingleOrDefault(x => x.Id == id);
        }

        public List<Customer> GetCustomers()
        {
            return customers;
        }
    }
}
