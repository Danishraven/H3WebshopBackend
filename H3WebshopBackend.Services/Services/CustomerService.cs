using H3WebshopBackend.Repository.Interfaces;
using H3WebshopBackend.Repository.Models;
using H3WebshopBackend.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace H3WebshopBackend.Services.Services
{
    public class CustomerService : ICustomerService
    {
        public ICustomerRepository CustomerRepository { get; set; }
        public CustomerService(ICustomerRepository customerRepository)
        {
            CustomerRepository = customerRepository;
        }

        public async Task<int> CreateCustomer(Customer Customer)
        {
            return await CustomerRepository.CreateCustomer(Customer);
        }

        public async Task<int> DeleteCustomer(Guid id)
        {
            return await CustomerRepository.DeleteCustomer(id);
        }

        public async Task<Customer[]> GetAll()
        {
            return await CustomerRepository.GetAll();
        }

        public async Task<Customer?> GetById(Guid id)
        {
            return await CustomerRepository.GetById(id);
        }

        public async Task<Customer[]> GetByName(string name)
        {
            return await CustomerRepository.GetByName(name);
        }

        public async Task<int> UpdateCustomer(Customer Customer)
        {
            return await CustomerRepository.UpdateCustomer(Customer);
        }

        public async Task<Customer[]> GetByCountry(string country)
        {
            return await CustomerRepository.GetByCountry(country);
        }

        public async Task<Customer[]> GetByZipCode(string zipCode)
        {
            return await CustomerRepository.GetByZipCode(zipCode);
        }

        public async Task<Customer[]> GetByEmail(string email)
        {
            return await CustomerRepository.GetByEmail(email);
        }
    }
}
