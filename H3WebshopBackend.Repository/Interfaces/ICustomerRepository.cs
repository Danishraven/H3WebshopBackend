using H3WebshopBackend.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3WebshopBackend.Repository.Interfaces
{
    public interface ICustomerRepository
    {
        public Task<Customer[]> GetAll();
        public Task<Customer?> GetById(Guid id);
        public Task<Customer[]> GetByName(string name);
        public Task<Customer[]> GetByCountry(string country);
        public Task<Customer[]> GetByZipCode(string zipCode);
        public Task<int> CreateCustomer(Customer Customer);
        public Task<int> UpdateCustomer(Customer Customer);
        public Task<int> DeleteCustomer(Guid id);
        public Task<Customer[]> GetByEmail(string email);
    }
}
