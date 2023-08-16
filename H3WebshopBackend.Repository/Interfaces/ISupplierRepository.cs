using H3WebshopBackend.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3WebshopBackend.Repository.Interfaces
{
    internal interface ISupplierRepository
    {
        public Task<Supplier[]> GetAll();
        public Task<Supplier?> GetById(int id);
        public Task<Supplier[]> GetByName(string name);
        public Task<int> CreateSupplier(Supplier Supplier);
        public Task<int> UpdateSupplier(Supplier Supplier);
        public Task<int> DeleteSupplier(int id);
    }
}
