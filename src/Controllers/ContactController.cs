using Microsoft.AspNetCore.Mvc;
using Portfolio.Repositories;
using Portfolio.ViewModels;

namespace Portfolio.Controllers
{
		/// <summary>
		/// Contact related Actions
		/// </summary>
    public class ContactController : Controller
    {
			private readonly IContactRepository _contactRepository;
      
			public ContactController(IContactRepository contactRepository)
			{
				_contactRepository = contactRepository;
			}

			/// <summary>
			/// REVIEW: Returns the contact page.
			/// </summary>
			/// <returns></returns>
			public ViewResult Index()
			{
				var contactViewModel = new ContactViewModel
				{
					ContactDetails = _contactRepository.ContactDetails
				};

				return View(contactViewModel);
			}
    }
}
