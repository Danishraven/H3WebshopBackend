using H3WebshopBackend.Repository.Interfaces;
using H3WebshopBackend.Repository.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace H3WebshopBackend.Repository.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public DatabaseContext Context { get; set; }
        public CustomerRepository(DatabaseContext context)
        {
            this.Context = context;
        }
        public async Task<int> CreateCustomer(Customer Customer)
        {
            await Context.Customer.AddAsync(Customer);
            return await Context.SaveChangesAsync();
        }

        public async Task<int> DeleteCustomer(Guid id)
        {
            var customer = await Context.Customer.FindAsync(id);
            if(customer == null) return 0;
            Context.Customer.Remove(customer);
            return await Context.SaveChangesAsync();
        }

        public async Task<Customer[]> GetAll()
        {
            try
            {
                var customers = Context.Customer.ToArray();
                return customers;

            }
            catch (Exception e)
            {
                var error = e;
                throw;
            }
        }

        public async Task<Customer?> GetById(Guid id)
        {
            return await Context.Customer.FindAsync(id);
        }

        public async Task<Customer[]> GetByName(string name)
        {
            return await Context.Customer.Where(customer => customer.Name == name).ToArrayAsync();
        }

        public async Task<int> UpdateCustomer(Customer Customer)
        {
            Context.Customer.Update(Customer);
            return await Context.SaveChangesAsync();
        }

        public async Task<Customer[]> GetByCountry(string country)
        {
            return await Context.Customer.Where(customer => customer.Country == country).ToArrayAsync();
        }

        public async Task<Customer[]> GetByZipCode(string zipCode)
        {
            return await Context.Customer.Where(customer => customer.ZipCode == zipCode).ToArrayAsync();
        }

        public async Task<Customer[]> GetByEmail(string email)
        {
            return Context.Customer.Where(customer => customer.Email == email).ToArray();
            try
            {
            }
            catch (Exception e)
            {
                var error = e.Message;
                Console.WriteLine(error);
                List<Customer> customerList = new();
                Customer[] customers = customerList.ToArray();
                return customers;
            }
        }
    }
}
