using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
	///<summary>
	///Basic controller for
	///the home page
	///</summary>
	public class HomeController : Controller
	{
		public ViewResult Index()
		{
			return View();
		}
	}
}
