using Entity.AppModel;

namespace ECommerce.App.Models
{
    public class CartItem
    {
        public Product Product { get; set; }
        public decimal TotalPrice { get; set; }
        public int Count { get; set; }
       
    }
}
