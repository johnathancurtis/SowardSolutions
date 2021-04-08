using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ConsultingProducts.Infrastructure;
using ConsultingProducts.Models;
using System.Linq;

namespace ConsultingProducts.Pages {

    public class CartModel : PageModel
    {
        private IStoreRepository repository;
        public CartModel(IStoreRepository repo, Cart cartService)
        {
            repository = repo;
            Cart = cartService;
        }
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";

            //Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        }
        public IActionResult OnPost(long productId, string returnUrl)
        {
            Product product = repository.Products
            .FirstOrDefault(p => p.ProductID == productId);
            Cart.AddItem(product, 1);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
        //public IActionResult OnPost(long productId, string returnUrl)
        //{
        //    Product product = repository.Products
        //       .FirstOrDefault(p => p.ProductID == productId);
        //    //Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        //    Cart.AddItem(product, 1);
        //    //HttpContext.Session.SetJson("cart", Cart);
        //    return RedirectToPage(new { returnUrl = returnUrl });
        //}
        public IActionResult OnPostRemove(long productId, string returnUrl)
        {
            Cart.RemoveLine(Cart.Lines.First(cl =>
            cl.Product.ProductID == productId).Product);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}