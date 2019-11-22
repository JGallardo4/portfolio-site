using System;
using Microsoft.AspNetCore.Mvc;

using Portfolio.Models;

namespace Portfolio.Controllers
{
	public class ProjectController : Controller
	{
		private readonly IProjectRepository _projectRepository;

		public ProjectController(IProjectRepository projectRepository)
		{
			_projectRepository = projectRepository;
		}

		public ViewResult List()
		{
			return View(_projectRepository.AllProjects);
		}
	}
}
