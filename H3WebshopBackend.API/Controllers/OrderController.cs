using H3WebshopBackend.Repository.Interfaces;
using H3WebshopBackend.Repository.Models;
using H3WebshopBackend.Repository.Models.DTOs;
using H3WebshopBackend.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace H3WebshopBackend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : IOrderController
    {
        public IOrderService OrderService { get; set; }
        public OrderController(IOrderService customerService)
        {
            OrderService = customerService;
        }
        [HttpPost]
        public async Task<int> CreateOrder([FromBody] OrderDTO orderDTO)
        {
            return await OrderService.CreateOrder(orderDTO);
        }
        [HttpDelete]
        public async Task<int> DeleteOrder(Guid id)
        {
            return await OrderService.DeleteOrder(id);
        }
        [HttpGet]
        public async Task<Order[]> GetAll()
        {
            return await OrderService.GetAll();
        }
        [HttpGet("id/{id}")]
        public async Task<Order?> GetById(Guid id)
        {
            return await OrderService.GetById(id);
        }
        [HttpPut]
        public async Task<int> UpdateOrder([FromBody] Order Order)
        {
            return await OrderService.UpdateOrder(Order);
        }
    }
}
