using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.ViewModels
{
    public class HomeViewModel 
    {
        public List<Team> teams { get; set; }
        public List<Product> products { get; set; }
    }
}
