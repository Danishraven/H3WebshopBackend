using H3WebshopBackend.Repository.Interfaces;
using H3WebshopBackend.Repository.Models;

namespace H3WebshopBackend.Frontend.Services
{
    public class FrontEndItemService : IItemController
    {
        public IItemController ItemController { get; set; }
        public FrontEndItemService(IItemController itemController)
        {
            ItemController = itemController;
        }

        public async Task<Item[]> GetAll()
        {
            return await ItemController.GetAll();
        }

        public async Task<Item?> GetById(Guid id)
        {
            return await ItemController.GetById(id);
        }

        public async Task<int> CreateItem(Item item)
        {
            return await ItemController.CreateItem(item);
        }

        public async Task<int> UpdateItem(Item item)
        {
            return await ItemController.UpdateItem(item);
        }

        public async Task<int> DeleteItem(Guid id)
        {
            return await ItemController.DeleteItem(id);
        }
    }
}
