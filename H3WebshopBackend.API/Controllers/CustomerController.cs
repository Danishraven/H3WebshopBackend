using H3WebshopBackend.API.Interfaces;
using H3WebshopBackend.Repository.Models;
using H3WebshopBackend.Repository.Repositories;
using H3WebshopBackend.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp;

namespace H3WebshopBackend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ICustomerController
    {
        public ICustomerService CustomerService { get; set; }
        public CustomerController(ICustomerService customerService)
        {
            CustomerService = customerService;
        }
        [HttpPost]
        public async Task<int> CreateCustomer([FromBody] Customer Customer)
        {
            return await CustomerService.CreateCustomer(Customer);
        }
        [HttpDelete]
        public async Task<int> DeleteCustomer(Guid id)
        {
            return await CustomerService.DeleteCustomer(id);
        }
        [HttpGet]
        public async Task<Customer[]> GetAll()
        {
            Customer[] svar = await CustomerService.GetAll();
            return svar;
        }
        [HttpGet("country/{country}")]
        public async Task<Customer[]> GetByCountry(string country)
        {
            return await CustomerService.GetByCountry(country);
        }
        [HttpGet("id/{id}")]
        public async Task<Customer?> GetById(Guid id)
        {
            return await CustomerService.GetById(id);
        }
        [HttpGet("name/{name}")]
        public async Task<Customer[]> GetByName(string name)
        {
            return await CustomerService.GetByName(name);
        }
        [HttpGet("zipCode/{zipCode}")]
        public async Task<Customer[]> GetByZipCode(string zipCode)
        {
            return await CustomerService.GetByZipCode(zipCode);
        }
        [HttpPut]
        public async Task<int> UpdateCustomer([FromBody] Customer Customer)
        {
            return await CustomerService.UpdateCustomer(Customer);
        }
        [HttpGet("email/{email}")]
        public async Task<Customer[]> GetByEmail(string email)
        {
            return await CustomerService.GetByEmail(email);
        }
    }
}
