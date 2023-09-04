using H3WebshopBackend.Repository.Models;
using H3WebshopBackend.Repository.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3WebshopBackend.Repository.Interfaces
{
    public interface IOrderRepository
    {
        public Task<Order[]> GetAll();
        public Task<Order?> GetById(Guid id);
        public Task<int> UpdateOrder(Order order);
        public Task<int> DeleteOrder(Guid id);
    }
}
