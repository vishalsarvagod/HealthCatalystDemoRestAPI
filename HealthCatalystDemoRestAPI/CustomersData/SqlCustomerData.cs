using HealthCatalystDemoRestAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthCatalystDemoRestAPI.CustomersData
{
    public class SqlCustomerData : ICustomersData
    {
        private CustomerContext.CustomerContext _customerContext;
        public SqlCustomerData(CustomerContext.CustomerContext customerContext)
        {
            _customerContext = customerContext;
        }
        public Customer AddCustomer(Customer customer)
        {
            customer.CustomerId = Guid.NewGuid();
            _customerContext.Customer.Add(customer);
            _customerContext.SaveChanges();
            return customer;
        }

        public void DeleteCustomer(Customer customer)
        {
            
            _customerContext.Customer.Remove(customer);
            _customerContext.SaveChanges();
          
        }

        public Customer EditCustomer(Customer customer)
        {
            var existingCustomer = _customerContext.Customer.Find(customer.CustomerId);
            if(existingCustomer != null)
            {
                _customerContext.Customer.Update(customer);
                _customerContext.SaveChanges();
            }

            return customer;

        }

        public Customer GetCustomer(Guid id)
        {
            var customer = _customerContext.Customer.Find(id);
            return customer;
        }

        public List<Customer> GetCustomers()
        {
            return _customerContext.Customer.ToList();
        }
    }
}
