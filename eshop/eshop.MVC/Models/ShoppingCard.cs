using eshop.Domain;

namespace eshop.MVC.Models
{
    public class BasketItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
    public class ShoppingCard
    {
        // TODO 1: Neden public olması gerektiğini açıkla!
        public List<BasketItem> BasketItems { get; set; } = new List<BasketItem>();

        public void Add(BasketItem item)
        {
            var existingItem = BasketItems.Find(p => p.Product.Id == item.Product.Id);
            if (existingItem != null)
            {
                existingItem.Quantity += item.Quantity;
            }
            else
            {
                BasketItems.Add(item);
            }

        }

        public void Clear() => BasketItems.Clear();
        public decimal? TotalPrice() => BasketItems.Sum(b => b.Quantity * b.Product.Price);


    }
}
