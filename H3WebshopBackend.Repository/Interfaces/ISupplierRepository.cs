using H3WebshopBackend.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3WebshopBackend.Repository.Interfaces
{
    public interface ISupplierRepository
    {
        public Task<Supplier[]> GetAll();
        public Task<Supplier?> GetById(Guid id);
        public Task<int> CreateSupplier(Supplier Supplier);
        public Task<int> UpdateSupplier(Supplier Supplier);
        public Task<int> DeleteSupplier(Guid id);
    }
}
