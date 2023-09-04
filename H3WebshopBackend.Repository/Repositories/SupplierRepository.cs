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
        public DatabaseContext Context { get; set; }
        public SupplierRepository(DatabaseContext Context)
        {
            this.Context = Context;
        }
        public async Task<int> CreateSupplier(Supplier supplier)
        {
            await Context.Supplier.AddAsync(supplier);
            return await Context.SaveChangesAsync();
        }

        public async Task<int> DeleteSupplier(Guid id)
        {
            var Supplier = await Context.Supplier.FindAsync(id);
            if(Supplier == null) return 0;
            Context.Supplier.Remove(Supplier);  
            return await Context.SaveChangesAsync();
        }

        public async Task<Supplier[]> GetAll()
        {
            return await Context.Supplier.ToArrayAsync();
        }

        public async Task<Supplier?> GetById(Guid id)
        {
            return await Context.Supplier.FirstOrDefaultAsync(i => i.Id == id);
        }

        public async Task<int> UpdateSupplier(Supplier supplier)
        {
            Context.Supplier.Update(supplier);
            return await Context.SaveChangesAsync();
        }
    }
}
