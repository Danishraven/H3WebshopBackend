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
    public class ItemRepository : IItemRepository
    {
        DatabaseContext context { get; set; }
        public ItemRepository(DatabaseContext context)
        {
            this.context = context;
        }
        public async Task<int> CreateItem(Item Item)
        {
            await context.Item.AddAsync(Item);
            int changes = await context.SaveChangesAsync();
            return changes;
        }

        public async Task<int> DeleteItem(int id)
        {
            var Item = await context.Item.FindAsync(id);
            if(Item == null) return 0;
            context.Item.Remove(Item);
            int changes = await context.SaveChangesAsync();
            return changes;
        }

        public async Task<Item[]> GetAll()
        {
            var Item = await context.Item.ToArrayAsync();
            return Item;
        }

        public async Task<Item?> GetById(int id)
        {
            var Item = await context.Item.FindAsync(id);
            return Item;
        }

        public async Task<Item[]> GetByName(string name)
        {
            var Item = await context.Item.Where(Item => Item.Name == name).ToArrayAsync();
            return Item;
        }

        public async Task<int> UpdateItem(Item Item)
        {
            context.Item.Update(Item);
            int changes = await context.SaveChangesAsync();
            return changes;
        }
    }
}
