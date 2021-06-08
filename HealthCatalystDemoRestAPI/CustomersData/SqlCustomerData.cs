using HealthCatalystDemoRestAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthCatalystDemoRestAPI.CustomersData
{
    public class SqlCustomerData : ICustomersData
    {
        private CustomerContext _customerContext;
        public SqlCustomerData(CustomerContext customerContext)
        {
            _customerContext = customerContext;
        }
        public Customer AddCustomer(Customer customer)
        {
            customer.CustomerId = Guid.NewGuid();
            _customerContext.Customers.Add(customer);
            _customerContext.SaveChanges();
            return customer;
        }

        public void DeleteCustomer(Customer customer)
        {
            
            _customerContext.Customers.Remove(customer);
            _customerContext.SaveChanges();
          
        }

        public Customer EditCustomer(Customer customer)
        {
            var existingCustomer = _customerContext.Customers.Find(customer.CustomerId);
            if(existingCustomer != null)
            {
                _customerContext.Customers.Update(customer);
                _customerContext.SaveChanges();
            }

            return customer;

        }

        public Customer GetCustomer(Guid id)
        {
            var customer = _customerContext.Customers.Find(id);
            return customer;
        }

        public List<Customer> GetCustomers()
        {
            return _customerContext.Customers.ToList();
        }
    }
}
