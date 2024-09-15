using Microsoft.AspNetCore.Mvc;
using Partial_view_and_view_component.DataAccessLayer;
using Partial_view_and_view_component.Models;
using System.Diagnostics;

namespace Partial_view_and_view_component.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbContext;

        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var products = _dbContext.Products.Take(4).ToList();

            var model = new HomeViewModel()
            {
                Products = products
            };
            return View(model);
        }

        public IActionResult LoadProducts()
        {

            var products = _dbContext.Products.Skip(4).Take(4).ToList();
            return PartialView("_ProductsPartial" ,products);
        }



    }
}
