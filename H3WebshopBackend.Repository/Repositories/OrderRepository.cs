using H3WebshopBackend.Repository.Interfaces;
using H3WebshopBackend.Repository.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3WebshopBackend.Repository.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        DatabaseContext context { get; set; }
        public OrderRepository(DatabaseContext context)
        {
            this.context = context;
        }
        public async Task<int> CreateOrder(Order Order)
        {
            await context.Order.AddAsync(Order);
            int changes = await context.SaveChangesAsync();
            return changes;
        }

        public async Task<int> DeleteOrder(int id)
        {
            var Order = await context.Order.FindAsync(id);
            if(Order == null) return 0;
            context.Order.Remove(Order);
            int changes = await context.SaveChangesAsync();
            return changes;
        }

        public async Task<Order[]> GetAll()
        {
            var Order = await context.Order.ToArrayAsync();
            return Order;
        }

        public async Task<Order?> GetById(int id)
        {
            var Order = await context.Order.FindAsync(id);
            return Order;
        }

        public async Task<int> UpdateOrder(Order Order)
        {
            context.Order.Update(Order);
            int changes = await context.SaveChangesAsync();
            return changes;
        }
    }
}
