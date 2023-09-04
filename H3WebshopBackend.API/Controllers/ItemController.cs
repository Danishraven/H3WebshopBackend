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
        public ItemController(IItemService customerService)
        {
            ItemService = customerService;
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
    }
}
