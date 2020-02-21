using Microsoft.AspNetCore.Mvc;
using Portfolio.Data;

namespace Portfolio.Controllers
{
	/// <summary>
	/// Project related Actions
	/// </summary>
	public class ProjectsController : Controller
	{
		private readonly AppDbContext _appDbContext;

		public ProjectsController(AppDbContext appDbContext)
		{
			_appDbContext = appDbContext;
		}

		/// <summary>
		/// Returns the projects list page.
		/// </summary>
		/// <returns></returns>
		public ViewResult Index()
		{
			return View(_appDbContext.Projects);
		}
	}
}
