using System;
using Microsoft.AspNetCore.Mvc;

using Portfolio.Repositories;
using Portfolio.ViewModels;

namespace Portfolio.Controllers
{
	/// <summary>
	/// Project related Actions
	/// </summary>
	public class ProjectController : Controller
	{
		private readonly IProjectRepository _projectRepository;

		public ProjectController(IProjectRepository projectRepository)
		{
			_projectRepository = projectRepository;
		}

		/// <summary>
		/// REVIEW: Add a description of the method.
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
