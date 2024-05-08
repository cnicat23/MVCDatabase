using Microsoft.AspNetCore.Mvc;
using WebApplication2.DAL;
using WebApplication2.Models;
using WebApplication2.ViewModels;

namespace WebApplication2.Controllers
{
	public class HomeController : Controller
	{
        private readonly AppDbContext _DbContext;

        public HomeController(AppDbContext dbContext)
        {
            _DbContext = dbContext;
        }
        public IActionResult Index()
		{
            List<Team> teams = _DbContext.teams.ToList();
            List<Product> products = _DbContext.Products.ToList();

            HomeViewModel viewModel = new HomeViewModel
            {
                teams = teams,
                products = products
            };
            return View(viewModel);
		}


    }
}
