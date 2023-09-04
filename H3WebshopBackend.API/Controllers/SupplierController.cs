using H3WebshopBackend.Repository.Interfaces;
using H3WebshopBackend.Repository.Models;
using H3WebshopBackend.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace H3WebshopBackend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ISupplierController
    {
        public ISupplierService SupplierService { get; set; }
        public SupplierController(ISupplierService customerService)
        {
            SupplierService = customerService;
        }
        [HttpPost]
        public async Task<int> CreateSupplier([FromBody] Supplier Supplier)
        {
            return await SupplierService.CreateSupplier(Supplier);
        }
        [HttpDelete]
        public async Task<int> DeleteSupplier(Guid id)
        {
            return await SupplierService.DeleteSupplier(id);
        }
        [HttpGet]
        public async Task<Supplier[]> GetAll()
        {
            return await SupplierService.GetAll();
        }
        [HttpGet("id/{id}")]
        public async Task<Supplier?> GetById(Guid id)
        {
            return await SupplierService.GetById(id);
        }
        [HttpPut]
        public async Task<int> UpdateSupplier([FromBody] Supplier Supplier)
        {
            return await SupplierService.UpdateSupplier(Supplier);
        }
    }
}
