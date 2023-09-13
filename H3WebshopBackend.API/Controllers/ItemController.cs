using H3WebshopBackend.Repository.Interfaces;
using H3WebshopBackend.Repository.Models;
using H3WebshopBackend.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace H3WebshopBackend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : IItemController
    {
        public IItemService ItemService { get; set; }
        public ItemController(IItemService itemService)
        {
            ItemService = itemService;
        }
        [HttpPost]
        public async Task<int> CreateItem([FromBody] Item item)
        {
            return await ItemService.CreateItem(item);
        }
        [HttpDelete]
        public async Task<int> DeleteItem(Guid id)
        {
            return await ItemService.DeleteItem(id);
        }
        [HttpGet]
        public async Task<Item[]> GetAll()
        {
            return await ItemService.GetAll();
        }
        [HttpGet("id/{id}")]
        public async Task<Item?> GetById(Guid id)
        {
            return await ItemService.GetById(id);
        }
        [HttpPut]
        public async Task<int> UpdateItem([FromBody] Item Item)
        {
            return await ItemService.UpdateItem(Item);
        }
        [HttpGet("expensive/{price}")]
        public async Task<Item[]> GetByMoreExpensive(int price)
        {
            var items = await ItemService.GetAll();
            IEnumerable<Item> expensiveItems =
                from item in items
                where item.Price > price
                select item;
            return expensiveItems.ToArray();
        }
        [HttpGet("supplier/{supplier}")]
        public async Task<Item[]> GetBySupplier(string supplier)
        {
            var items = await ItemService.GetAll();
            IEnumerable<Item> itemsBySupplier = items.Where(item => item.Supplier != null)
                                                     .Where(item => item.Supplier.Name == supplier);
            return itemsBySupplier.ToArray();
        }
    }
}
