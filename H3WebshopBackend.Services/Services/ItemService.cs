using H3WebshopBackend.Repository.Interfaces;
using H3WebshopBackend.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3WebshopBackend.Services.Services
{
    public class ItemService : IItemService
    {
        public IItemRepository ItemRepository { get; set; }
        public ItemService(IItemRepository itemRepository)
        {
            ItemRepository = itemRepository;
        }

        public async Task<int> CreateItem(Item item)
        {
            return await ItemRepository.CreateItem(item);
        }

        public async Task<int> DeleteItem(Guid id)
        {
            return await ItemRepository.DeleteItem(id);
        }

        public async Task<Item[]> GetAll()
        {
            return await ItemRepository.GetAll();
        }

        public async Task<Item?> GetById(Guid id)
        {
            return await ItemRepository.GetById(id);
        }

        public async Task<int> UpdateItem(Item item)
        {
            return await ItemRepository.UpdateItem(item);
        }
    }
}
