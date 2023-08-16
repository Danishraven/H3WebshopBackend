using H3WebshopBackend.Repository.Interfaces;
using H3WebshopBackend.Repository.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3WebshopBackend.Repository.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        DatabaseContext context { get; set; }
        public CustomerRepository(DatabaseContext context)
        {
            this.context = context;
        }
        public async Task<int> CreateCustomer(Customer Customer)
        {
            await context.Customer.AddAsync(Customer);
            int changes = await context.SaveChangesAsync();
            return changes;
        }

        public async Task<int> DeleteCustomer(int id)
        {
            var customer = await context.Customer.FindAsync(id);
            if(customer == null) return 0;
            context.Customer.Remove(customer);
            int changes = await context.SaveChangesAsync();
            return changes;
        }

        public async Task<Customer[]> GetAll()
        {
            var customer = await context.Customer.ToArrayAsync();
            return customer;
        }

        public async Task<Customer?> GetById(int id)
        {
            var customer = await context.Customer.FindAsync(id);
            return customer;
        }

        public async Task<Customer[]> GetByName(string name)
        {
            var customer = await context.Customer.Where(customer => customer.Name == name).ToArrayAsync();
            return customer;
        }

        public async Task<int> UpdateCustomer(Customer Customer)
        {
            context.Customer.Update(Customer);
            int changes = await context.SaveChangesAsync();
            return changes;
        }
    }
}
