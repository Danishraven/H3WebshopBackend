using H3WebshopBackend.API.Controllers;
using H3WebshopBackend.API.Interfaces;
using H3WebshopBackend.Repository.Models;
using H3WebshopBackend.Repository.Repositories;

namespace H3WebshopBackend.Frontend.Services
{
    public class FrontEndCustomerService : ICustomerController
    {
        public ICustomerController CustomerController;
        public FrontEndCustomerService(ICustomerController customerController)
        {
            CustomerController = customerController;
        }

        public async Task<int> CreateCustomer(Customer Customer)
        {
            return await CustomerController.CreateCustomer(Customer);
        }

        public async Task<int> DeleteCustomer(Guid id)
        {
            return await CustomerController.DeleteCustomer(id);
        }

        public async Task<Customer[]> GetAll()
        {
            return await CustomerController.GetAll();
        }

        public async Task<Customer[]> GetByCountry(string country)
        {
            return await CustomerController.GetByCountry(country);
        }

        public async Task<Customer?> GetById(Guid id)
        {
            return await CustomerController.GetById(id);
        }

        public async Task<Customer[]> GetByName(string name)
        {
            return await CustomerController.GetByName(name);
        }

        public async Task<Customer[]> GetByZipCode(string zipCode)
        {
            return await CustomerController.GetByZipCode(zipCode);
        }

        public async Task<int> UpdateCustomer(Customer Customer)
        {
            return await CustomerController.UpdateCustomer(Customer);
        }

        public async Task<Customer[]> GetByEmail(string email)
        {
            return await CustomerController.GetByEmail(email);
        }
    }
}
