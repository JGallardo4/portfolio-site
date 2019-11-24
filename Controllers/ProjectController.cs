using System;
using Microsoft.AspNetCore.Mvc;

using Portfolio.Models;
using Portfolio.ViewModels;

namespace Portfolio.Controllers
{
	public class ProjectController : Controller
	{
		private readonly IProjectRepository _projectRepository;

		public ProjectController(IProjectRepository projectRepository)
		{
			_projectRepository = projectRepository;
		}

		public ViewResult Index()
		{
            Console.WriteLine("In action method");
			ProjectsListViewModel projectsListViewModel = new ProjectsListViewModel();
			projectsListViewModel.Projects = _projectRepository.GetAll;

            return View(projectsListViewModel);
		}
	}
}
