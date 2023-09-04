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
        public DatabaseContext Context { get; set; }
        public ItemRepository(DatabaseContext Context)
        {
            this.Context = Context;
        }
        public async Task<int> CreateItem(Item item)
        {
            if (item == null || item.Supplier == null)
            {
                return 0;
            }
            SupplierRepository supplierRepository = new(Context);
            item.Supplier = await supplierRepository.GetById(item.Supplier.Id);
            await Context.Item.AddAsync(item);
            int changes = await Context.SaveChangesAsync();
            return changes;
        }

        public async Task<int> DeleteItem(Guid id)
        {
            var Item = await Context.Item.FindAsync(id);
            if(Item == null) return 0;
            Context.Item.Remove(Item);
            int changes = await Context.SaveChangesAsync();
            return changes;
        }

        public async Task<Item[]> GetAll()
        {
            var Item = await Context.Item.Include(p => p.Supplier).ToArrayAsync();
            return Item;
        }

        public async Task<Item?> GetById(Guid id)
        {
            //var Item = await Context.Item.FindAsync(id);
            var Item = await Context.Item.Include(p => p.Supplier).FirstOrDefaultAsync(i => i.Id == id);
            return Item;
        }

        public async Task<int> UpdateItem(Item Item)
        {
            Context.Item.Update(Item);
            int changes = await Context.SaveChangesAsync();
            return changes;
        }
    }
}