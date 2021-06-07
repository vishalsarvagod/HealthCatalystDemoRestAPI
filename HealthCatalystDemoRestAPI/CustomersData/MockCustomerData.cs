using HealthCatalystDemoRestAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthCatalystDemoRestAPI.CustomerContext;

namespace HealthCatalystDemoRestAPI.CustomersData
{
    public class MockCustomerData : ICustomersData
    {
        //private List<Customer> customers = new List<Customer>()
        //{
        //    new Customer()
        //    {
        //        Id = Guid.NewGuid(),
        //        Name = "Vishal Sarvagod"
        //    },
        //    new Customer()
        //    {
        //        Id = Guid.NewGuid(),
        //        Name = "Vivek Sarvagod"
        //    },
        //};
        
        //public MockCustomerData()
        //{
            
        //}
        
        //public Customer AddCustomer(Customer customer)
        //{
        //    customer.CustomerId = Guid.NewGuid();
        //    var ct = new CustomerContext.CustomerContext();
        //    ct.Add(customer);
        //    ct.SaveChanges();
        //    return customer;
        //}

        //public void DeleteCustomer(Customer customer)
        //{
        //    var ct = new CustomerContext.CustomerContext();
        //    ct.Remove(customer);
        //    //customers.Remove(customer);
        //}

        //public Customer EditCustomer(Customer customer)
        //{
        //    var existingCustomer = GetCustomer(customer.CustomerId);
        //    existingCustomer.Name = customer.Name;
        //    return existingCustomer;
        //}

        //public Customer GetCustomer(Guid id)
        //{
        //    var ct = new CustomerContext.CustomerContext();
        //    var query = ct.Customer.Where(s => s.CustomerId == id).FirstOrDefault<Customer>();
        //    return query;
        //}

        //public List<Customer> GetCustomers()
        //{
        //    var ct = new CustomerContext.CustomerContext();
        //    return ct.Customer.ToList();
        //}
    }
}
