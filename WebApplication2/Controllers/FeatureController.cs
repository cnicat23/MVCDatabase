﻿using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
	public class FeatureController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
