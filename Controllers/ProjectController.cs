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

		public ViewResult AllProjects()
		{
			ProjectsListViewModel projectsListViewModel = new ProjectsListViewModel();
			projectsListViewModel.Projects = _projectRepository.AllProjects;
			
			return View(projectsListViewModel);
		}

		public ViewResult AllWithTags()
		{	
			ProjectsListViewModel projectsListViewModel = new ProjectsListViewModel();
			projectsListViewModel.Projects = _projectRepository.AllWithTags;

			return View(projectsListViewModel);
		}
	}
}
