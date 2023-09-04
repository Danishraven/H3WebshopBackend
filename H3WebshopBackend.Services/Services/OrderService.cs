using H3WebshopBackend.Repository.Interfaces;
using H3WebshopBackend.Repository.Models;
using H3WebshopBackend.Repository.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3WebshopBackend.Services.Services
{
    public class OrderService : IOrderService
    {
        public IOrderRepositoryTargeted OrderRepository { get; set; }
        public OrderService(IOrderRepositoryTargeted orderRepository)
        {
            OrderRepository = orderRepository;
        }

        public async Task<int> CreateOrder(OrderDTO orderDTO)
        {
            int linesChanged = 0;
            foreach (var item in orderDTO.Item)
            {
                Order order = new Order();
                order.Item = item;
                order.Id = orderDTO.Id;
                order.Customer = orderDTO.Customer;
                order.DateTime = orderDTO.DateTime;
                linesChanged += await OrderRepository.CreateOrder(order);
            }
            return linesChanged;
        }

        public async Task<int> DeleteOrder(Guid id)
        {
            return await OrderRepository.DeleteOrder(id);
        }

        public async Task<Order[]> GetAll()
        {
            return await OrderRepository.GetAll();
        }

        public async Task<Order?> GetById(Guid id)
        {
            return await OrderRepository.GetById(id);
        }

        public async Task<int> UpdateOrder(Order Order)
        {
            return await OrderRepository.UpdateOrder(Order);
        }
    }
}
