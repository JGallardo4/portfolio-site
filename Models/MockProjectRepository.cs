using System.Collections.Generic;
using System.Linq;

namespace Portfolio.Models
{
	public class MockProjectRepository: IProjectRepository
	{
		public IEnumerable<Project> AllProjects =>
			new List<Project>
			{
				new Project {
					ProjectId = 1,
					Name = "Portfolio Site",
					Description = "Check out my cool projects",
					GithubUrl = "https://github.com/Juan-G-04/portfolio-site",
					Featured = true,
					ImageUrl = "https://insektenliebe.com/wp-content/uploads/2019/01/IMG_8316.jpg",
					Tags = "csharp, asp.net core mvc, html, css, js",
					LiveUrl = "www.jgallardo.dev"
				},
				new Project {
					ImageUrl = "https://i.redd.it/5fwbf05fp0041.jpg",
					Name = "ShareNet",
					Description = "Don't spend money give and get stuff for free. A community classifieds website.",
					GithubUrl = "https://github.com/Juan-G-04/sharenet-aspnet",
					LiveUrl = "www.sharenet.col",
					Tags = "csharp, mvc, asp.net, .net core 3.0, html, css, js",
					Featured = true
				},
				new Project {
					ImageUrl = "https://external-content.duckduckgo.com/iu/?u=http%3A%2F%2F4.bp.blogspot.com%2F-Jx21kNqFSTU%2FUXemtqPhZCI%2FAAAAAAAAh74%2FBMGSzpU6F48%2Fs1600%2Ffunny-cat-pictures-047-001.jpg&f=1&nofb=1",
					Name = "Isogame",
					Description = "A javascript browser game where you play as a terrastrial isopod.",
					GithubUrl = "not found",
					LiveUrl = "www.isogame.com",
					Tags = "game, javascript, html5",
					Featured = false
				}
			};
		
		public Project GetProjectById(int projectId)
		{
			return AllProjects.FirstOrDefault(p => p.ProjectId == projectId);
		}

		public IEnumerable<Project> AllFeatured => 
			AllProjects.Where(p => p.Featured == true);
	}
}
