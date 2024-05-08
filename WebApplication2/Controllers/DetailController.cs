using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
	public class DetailController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
