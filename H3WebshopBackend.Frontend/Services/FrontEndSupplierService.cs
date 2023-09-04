using H3WebshopBackend.Repository.Interfaces;
using H3WebshopBackend.Repository.Models;

namespace H3WebshopBackend.Frontend.Services
{
    public class FrontEndSupplierService : ISupplierController
    {
        public ISupplierController SupplierController { get; set; }
        public FrontEndSupplierService(ISupplierController supplierController)
        {
            this.SupplierController = supplierController;
        }

        public async Task<Supplier[]> GetAll()
        {
            return await SupplierController.GetAll();
        }

        public async Task<Supplier?> GetById(Guid id)
        {
            return await SupplierController.GetById(id);
        }

        public async Task<int> CreateSupplier(Supplier Supplier)
        {
            return await SupplierController.CreateSupplier(Supplier);
        }

        public async Task<int> UpdateSupplier(Supplier Supplier)
        {
            return await SupplierController.UpdateSupplier(Supplier);
        }

        public async Task<int> DeleteSupplier(Guid id)
        {
            return await SupplierController.DeleteSupplier(id);
        }
    }
}
