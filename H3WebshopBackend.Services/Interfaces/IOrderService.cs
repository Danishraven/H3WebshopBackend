using H3WebshopBackend.Repository.Models;
using H3WebshopBackend.Repository.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3WebshopBackend.Repository.Interfaces
{
    public interface IOrderService : IOrderRepository
    {
        public Task<int> CreateOrder(OrderDTO order);
    }
}
