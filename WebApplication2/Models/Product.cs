﻿using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Models
{
	public class Product 
	{
        public int Id { get; set; }
		public string Image { get; set; }
		public string Name { get; set; }
		public decimal Price { get; set; }
		
    }
}
