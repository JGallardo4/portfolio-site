using Microsoft.AspNetCore.Mvc;

using Portfolio.Repositories;
using Portfolio.ViewModels;

namespace Portfolio.Controllers
{
	/// <summary>
	/// Project related Actions
	/// </summary>
	public class ProjectsController : Controller
	{
		private readonly IProjectRepository _projectRepository;

		public ProjectsController(IProjectRepository projectRepository)
		{
			_projectRepository = projectRepository;
		}

		/// <summary>
		/// REVIEW: Returns the projects list page.
		/// </summary>
		/// <returns></returns>
		public ViewResult Index()
		{
			var projectsListViewModel = new ProjectsListViewModel
			{
				Projects = _projectRepository.GetAll
			};

			return View(projectsListViewModel);
		}
	}
}
