using Microsoft.AspNetCore.Mvc;
using Portfolio.ViewModels;

namespace Portfolio.Controllers
{
		/// <summary>
		/// Contact related Actions
		/// </summary>
    public class ContactController : Controller
    {
      
			public ContactController()
			{
			}

			/// <summary>
			/// REVIEW: Returns the contact page.
			/// </summary>
			/// <returns></returns>
			public ViewResult Index()
			{
				var contactViewModel = new ContactViewModel
				{
				};

				return View(contactViewModel);
			}
    }
}
