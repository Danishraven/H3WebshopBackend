using H3WebshopBackend.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3WebshopBackend.Repository.Interfaces
{
    internal interface ICustomerRepository
    {
        public Task<Customer[]> GetAll();
        public Task<Customer?> GetById(int id);
        public Task<Customer[]> GetByName(string name);
        public Task<int> CreateCustomer(Customer Customer);
        public Task<int> UpdateCustomer(Customer Customer);
        public Task<int> DeleteCustomer(int id);
    }
}
