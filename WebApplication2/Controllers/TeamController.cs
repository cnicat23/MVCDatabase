using Microsoft.AspNetCore.Mvc;
using WebApplication2.DAL;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
	public class TeamController : Controller
	{
		private readonly AppDbContext _DbContext;
        public TeamController(AppDbContext dbContext)
        {
				_DbContext = dbContext;
        }
        public IActionResult Index()
		{
			//Team team1 = new Team
			//{
			//	Image = "team-1.jpg",
			//	Name = "Sirac",
			//	Designation = "Back end",
			//	TwLink = "www.facebook.com/Sirac",
			//	FCLink = "www.facebook.com/Sirac",
			//	InLink = "www.facebook.com/Sirac",
			//	InstaLink = "www.facebook.com/Sirac",
   //         };
   //         Team team2 = new Team
   //         {
   //             Image = "team-2.jpg",
   //             Name = "Zaman",
   //             Designation = "Back end",
   //             TwLink = "www.facebook.com/Zaman12",
   //             FCLink = "www.facebook.com/Zaman12",
   //             InLink = "www.facebook.com/Zaman12",
   //             InstaLink = "www.facebook.com/Zaman12",
   //         }; 
   //         Team team3 = new Team
   //         {
   //             Image = "team-3.jpg",
   //             Name = "Eli",
   //             Designation = "Back end",
   //             TwLink = "www.facebook.com/Eli",
   //             FCLink = "www.facebook.com/Eli",
   //             InLink = "www.facebook.com/Eli",
   //             InstaLink = "www.facebook.com/Eli",
   //         }; 
   //         Team team4 = new Team
   //         {
   //             Image = "team-2.jpg",
   //             Name = "Araz",
   //             Designation = "Front end",
   //             TwLink = "www.facebook.com/Araz02",
   //             FCLink = "www.facebook.com/Araz02",
   //             InLink = "www.facebook.com/Araz02",
   //             InstaLink = "www.facebook.com/Araz02",
   //         }; 
   //         Team team5 = new Team
   //         {
   //             Image = "team-3.jpg",
   //             Name = "Fuad",
   //             Designation = "Back end",
   //             TwLink = "www.facebook.com/Fuad66",
   //             FCLink = "www.facebook.com/Fuad66",
   //             InLink = "www.facebook.com/Fuad66",
   //             InstaLink = "www.facebook.com/Fuad66",
   //         };
   //         Team team6 = new Team
   //         {
   //             Image = "team-1.jpg",
   //             Name = "Cavid",
   //             Designation = "Back end",
   //             TwLink = "www.facebook.com/Cavid22",
   //             FCLink = "www.facebook.com/Cavid22",
   //             InLink = "www.facebook.com/Cavid22",
   //             InstaLink = "www.facebook.com/Cavid22",
   //         };
   //         List<Team> teams = new List<Team> { team1, team2, team3, team4, team5, team6 };
   //         _DbContext.teams.AddRange(teams);
   //         _DbContext.SaveChanges();

			List<Team> teams = _DbContext.teams.ToList();
            return View(teams);
		}
	}
}
