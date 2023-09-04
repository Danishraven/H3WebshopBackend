using H3WebshopBackend.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3WebshopBackend.Repository.Interfaces
{
    public interface IItemRepository
    {
        public Task<Item[]> GetAll();
        public Task<Item?> GetById(Guid id);
        public Task<int> CreateItem(Item item);
        public Task<int> UpdateItem(Item item);
        public Task<int> DeleteItem(Guid id);
    }
}
