using H3WebshopBackend.Repository.Models;

namespace H3WebshopBackend.Frontend.Services
{
    public class ShoppingCartService
    {
        public List<Item> Cart { get; set; } = new();

        public  void AddToCart(Item item)
        {
            Cart.Add(item);
        }
    }
}
