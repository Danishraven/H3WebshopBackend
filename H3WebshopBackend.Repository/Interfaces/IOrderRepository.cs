using H3WebshopBackend.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3WebshopBackend.Repository.Interfaces
{
    internal interface IOrderRepository
    {
        public Task<Order[]> GetAll();
        public Task<Order?> GetById(int id);
        public Task<Order[]> GetByName(string name);
        public Task<int> CreateOrder(Order Order);
        public Task<int> UpdateOrder(Order Order);
        public Task<int> DeleteOrder(int id);
    }
}
