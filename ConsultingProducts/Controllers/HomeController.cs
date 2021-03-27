using Microsoft.AspNetCore.Mvc;
using ConsultingProducts.Models;

namespace ConsultingProducts.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository repository;

        public HomeController(IStoreRepository repo)
        {
            repository = repo;
        }
        public IActionResult Index()
        {
            return View(repository.Products);
        }  
    }
}
