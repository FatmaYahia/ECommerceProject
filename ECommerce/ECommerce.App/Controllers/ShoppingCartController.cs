using ECommerce.App.Models;
using Entity.AppModel;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace ECommerce.App.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly UnitOfWork UOW;
        private static List<CartItem> CartItems = new List<CartItem>();
        
        public ShoppingCartController(UnitOfWork UOW)
        {
            this.UOW = UOW;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddToCart(int id)
        {
            Product product = UOW.ProductRepository.GetById(id);
            if( CartItems.Any(x => x.Product.Id == product.Id))
            {
                var item = CartItems.Where(x => x.Product.Id == product.Id).FirstOrDefault();
                item.TotalPrice += product.Offer == 0 ? product.Price : (product.Price - (product.Price / 100 * product.Offer));
                item.Count += 1;
            }
            else
            {
                CartItem cartItem = new CartItem()
                {
                    Product = product,
                    Count = 1,

                    TotalPrice = product.Offer == 0 ? product.Price : (product.Price - (product.Price / 100 * product.Offer))
                };
                CartItems.Add(cartItem);
            }
           
           
            return View(CartItems);
        }
        public IActionResult AddOne(int productid)
        {
            Product product = UOW.ProductRepository.GetById(productid);
            if (CartItems.Any(x => x.Product.Id == product.Id))
            {
                var item = CartItems.Where(x => x.Product.Id == product.Id).FirstOrDefault();
                item.TotalPrice += product.Offer == 0 ? product.Price : (product.Price - (product.Price / 100 * product.Offer));
                item.Count += 1;
            }
            return View("Summary",CartItems);
        }
        public IActionResult SubOne(int productid)
        {
            Product product = UOW.ProductRepository.GetById(productid);
            if (CartItems.Any(x => x.Product.Id == product.Id))
            {
                var item = CartItems.Where(x => x.Product.Id == product.Id).FirstOrDefault();
                if(item.Count == 1)
                {
                    CartItems.Remove(item);
                }
                else
                {
                    item.TotalPrice -= product.Offer == 0 ? product.Price : (product.Price - (product.Price / 100 * product.Offer));
                    item.Count -= 1;
                }
                
            }
            return View("Summary", CartItems);
        }
    }
}
