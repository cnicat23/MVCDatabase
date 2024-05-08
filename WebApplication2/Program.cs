using Microsoft.EntityFrameworkCore;
using WebApplication2.DAL;

namespace WebApplication2
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);
			builder.Services.AddControllersWithViews();
			builder.Services.AddDbContext<AppDbContext>(options =>
			{
				options.UseSqlServer("Server=DESKTOP-D323LT8\\SQLEXPRESS;Database=FarmFresh;Trusted_Connection=true;" +
					"Integrated Security=true;TrustServerCertificate=true");
			});
			var app = builder.Build();

			//app.MapGet("/", () => "Hello World!");
			app.UseStaticFiles();
			app.MapControllerRoute("default", "{controller=Home}/{action=Index}");
			app.Run();
		}
	}
}
