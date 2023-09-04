using H3WebshopBackend.Repository.Interfaces;
using H3WebshopBackend.Repository.Models;
using H3WebshopBackend.Repository.Models.DTOs;

namespace H3WebshopBackend.Frontend.Services
{
    public class FrontEndOrderService : IOrderController
    {
        public IOrderController OrderController { get; set; }
        public FrontEndOrderService(IOrderController orderController)
        {
            OrderController = orderController;
        }

        public async Task<Order[]> GetAll()
        {
            return await OrderController.GetAll();
        }

        public async Task<Order?> GetById(Guid id)
        {
            return await OrderController.GetById(id);
        }

        public async Task<int> CreateOrder(OrderDTO Order)
        {
            return await OrderController.CreateOrder(Order);
        }

        public async Task<int> UpdateOrder(Order Order)
        {
            return await OrderController.UpdateOrder(Order);
        }

        public async Task<int> DeleteOrder(Guid id)
        {
            return await OrderController.DeleteOrder(id);
        }
    }
}
