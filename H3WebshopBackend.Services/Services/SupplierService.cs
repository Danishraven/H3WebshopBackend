using H3WebshopBackend.Repository.Interfaces;
using H3WebshopBackend.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3WebshopBackend.Services.Services
{
    public class SupplierService : ISupplierService
    {
        public ISupplierRepository SupplierRepository { get; set; }
        public SupplierService(ISupplierRepository supplierRepository)
        {
            SupplierRepository = supplierRepository;
        }

        public async Task<Supplier[]> GetAll()
        {
            return await SupplierRepository.GetAll();
        }

        public async Task<Supplier?> GetById(Guid id)
        {
            return await SupplierRepository.GetById(id);
        }

        public async Task<int> CreateSupplier(Supplier Supplier)
        {
            return await SupplierRepository.CreateSupplier(Supplier);
        }

        public async Task<int> UpdateSupplier(Supplier Supplier)
        {
            return await SupplierRepository.UpdateSupplier(Supplier);
        }

        public async Task<int> DeleteSupplier(Guid id)
        {
            return await SupplierRepository.DeleteSupplier(id);
        }
    }
}
