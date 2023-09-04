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
    public class OrderRepository : IOrderRepositoryTargeted
    {
        public DatabaseContext Context { get; set; }
        public OrderRepository(DatabaseContext Context)
        {
            this.Context = Context;
        }
        public async Task<int> CreateOrder(Order order)
        {
            if (order.Item == null || order.Customer == null || order == null)
            {
                return 0;
            }
            ItemRepository itemRepository = new(Context);
            var item = await itemRepository.GetById(order.Item.Id);
            CustomerRepository customerRepository = new(Context);
            var customer = await customerRepository.GetById(order.Customer.Id);
            if (customer != null && item != null)
            {
                order.Customer = customer;
                order.Item = item;
            }
            await Context.Order.AddAsync(order);
            int changes = await Context.SaveChangesAsync();
            return changes;
        }

        public async Task<int> DeleteOrder(Guid id)
        {
            var Order = await Context.Order.FindAsync(id);
            if(Order == null) return 0;
            Context.Order.Remove(Order);
            int changes = await Context.SaveChangesAsync();
            return changes;
        }

        public async Task<Order[]> GetAll()
        {
            return await Context.Order.Include(p => p.Item).Include(p => p.Customer).Include(p => p.Item.Supplier).ToArrayAsync();
        }

        public async Task<Order?> GetById(Guid id)
        {
            var Order = await Context.Order.Include(p => p.Item).Include(p => p.Customer).Include(p => p.Item.Supplier).FirstOrDefaultAsync(p => p.Id == id);
            return Order;
        }

        public async Task<int> UpdateOrder(Order Order)
        {
            Context.Order.Update(Order);
            int changes = await Context.SaveChangesAsync();
            return changes;
        }
    }
}
