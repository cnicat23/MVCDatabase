﻿using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
	public class ServiceController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
