using System.Collections.Generic;
using System.Linq;
using Portfolio.Models;

namespace Portfolio.Repositories
{
	/// <summary>
	/// A temporary store for my list of projects.
	/// To be replaced by an implementation that
	/// makes use of a JSON file.
	/// </summary>
	public class MockProjectRepository : IProjectRepository
	{
		private readonly IEnumerable<Project> _projects;

		public MockProjectRepository()
		{
			_projects = new List<Project>
			{
				new Project
				{
					Name = "Portfolio Site",
					Description = "Check out my cool projects",
					GithubUrl = "https://github.com/Juan-G-04/portfolio-site",
					LiveUrl = "www.jgallardo.dev",
					ImageUrl = "https://insektenliebe.com/wp-content/uploads/2019/01/IMG_8316.jpg",
					Tags = new List<Tag> {Tag.CSHARP, Tag.MVC, Tag.HTML, Tag.CSS, Tag.JS},
					Featured = true,
				},
				new Project
				{
					Name = "ShareNet",
					Description = "Don't spend money give and get stuff for free. A community classifieds website.",
					GithubUrl = "https://github.com/Juan-G-04/sharenet-aspnet",
					LiveUrl = "www.sharenet.col",
					ImageUrl = "https://i.redd.it/5fwbf05fp0041.jpg",
					Tags = new List<Tag> {Tag.CSHARP, Tag.MVC, Tag.HTML, Tag.CSS, Tag.JS},
					Featured = true
				},
				new Project
				{
					Name = "Isogame",
					Description = "A javascript browser game where you play as a terrastrial isopod.",
					GithubUrl = "not found",
					LiveUrl = "www.isogame.com",
					ImageUrl = "https://external-content.duckduckgo.com/iu/?u=http%3A%2F%2F4.bp.blogspot.com%2F-Jx21kNqFSTU%2FUXemtqPhZCI%2FAAAAAAAAh74%2FBMGSzpU6F48%2Fs1600%2Ffunny-cat-pictures-047-001.jpg&f=1&nofb=1",
					Tags = new List<Tag> {Tag.CSHARP, Tag.MVC, Tag.HTML, Tag.CSS, Tag.JS},
					Featured = false
				}
			};
		}

		public IEnumerable<Project> GetAll => _projects;

		}
}
