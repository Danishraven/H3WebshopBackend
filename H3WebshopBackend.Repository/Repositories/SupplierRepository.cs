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
    public class SupplierRepository : ISupplierRepository
    {
        DatabaseContext context { get; set; }
        public SupplierRepository(DatabaseContext context)
        {
            this.context = context;
        }
        public async Task<int> CreateSupplier(Supplier Supplier)
        {
            await context.Supplier.AddAsync(Supplier);
            int changes = await context.SaveChangesAsync();
            return changes;
        }

        public async Task<int> DeleteSupplier(int id)
        {
            var Supplier = await context.Supplier.FindAsync(id);
            if(Supplier == null) return 0;
            context.Supplier.Remove(Supplier);
            int changes = await context.SaveChangesAsync();
            return changes;
        }

        public async Task<Supplier[]> GetAll()
        {
            var Supplier = await context.Supplier.ToArrayAsync();
            return Supplier;
        }

        public async Task<Supplier?> GetById(int id)
        {
            var Supplier = await context.Supplier.FindAsync(id);
            return Supplier;
        }

        public async Task<Supplier[]> GetByName(string name)
        {
            var Supplier = await context.Supplier.Where(Supplier => Supplier.Name == name).ToArrayAsync();
            return Supplier;
        }

        public async Task<int> UpdateSupplier(Supplier Supplier)
        {
            context.Supplier.Update(Supplier);
            int changes = await context.SaveChangesAsync();
            return changes;
        }
    }
}
