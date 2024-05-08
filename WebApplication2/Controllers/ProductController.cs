using Microsoft.AspNetCore.Mvc;
using WebApplication2.DAL;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
	public class ProductController : Controller
	{
		private readonly AppDbContext _DbContext;

        public ProductController(AppDbContext dbContext)
        {
            _DbContext = dbContext;
        }
        public IActionResult Index()
		{
			//Product product1 = new Product
			//{
			//	Image = "product-1.png",
			//	Name = "organic-vegetable",
			//	Price = 25,

			//};
			//Product product2 = new Product
			//{
			//	Image = "product-2.png",
			//	Name = "organic-fruit",
			//	Price= 20,

			//}; Product product3 = new Product
			//{
			//	Image = "product-1.png",
			//	Name = "organic-vegetable",
			//	Price = 30,


			//}; Product product4 = new Product
			//{
			//	Image = "product-2.png",
			//	Name = "terevez",
			//	Price = 20,


			//}; Product product5 = new Product
			//{
			//	Image ="product-1.png",
			//	Name = "terevez",
			//	Price = 15,
			//};

			//List<Product> products = new List<Product> { product1, product2, product3, product4, product5 };
			//_DbContext.Products.AddRange(products);
			//_DbContext.SaveChanges();

			List<Product> products = _DbContext.Products.ToList();
			return View(products);
		}
	}
}
