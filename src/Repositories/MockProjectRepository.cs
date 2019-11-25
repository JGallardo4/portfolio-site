using System.Collections.Generic;
using System.Linq;
using Portfolio.Models;

namespace Portfolio.Repositories
{
    /// <summary>
    /// REVIEW: Add a description of the class.
    /// </summary>
	public class MockProjectRepository : IProjectRepository
	{
        private readonly IEnumerable<Project> Projects;

        public MockProjectRepository()
        {

            // REVIEW: I would start by reordering the initialization variables so they're all in the same order, and
            // at a later time, possibly moving this into a json/xml file or something similar
            Projects = new List<Project>
            {
                new Project
                {
                    ProjectId = 1,
                    Name = "Portfolio Site",
                    Description = "Check out my cool projects",
                    GithubUrl = "https://github.com/Juan-G-04/portfolio-site",
                    Featured = true,
                    ImageUrl = "https://insektenliebe.com/wp-content/uploads/2019/01/IMG_8316.jpg",
                    // REVIEW: Consider making this a list of Enums rather than strings. I started an enum class for these tags already,
                    // you can add more tags to this file. 
                    Tags = new List<Tag> {Tag.CSHARP, Tag.MVC, Tag.HTML, Tag.CSS, Tag.JS},
                    LiveUrl = "www.jgallardo.dev"
                },
                new Project
                {
                    ImageUrl = "https://i.redd.it/5fwbf05fp0041.jpg",
                    Name = "ShareNet",
                    Description = "Don't spend money give and get stuff for free. A community classifieds website.",
                    GithubUrl = "https://github.com/Juan-G-04/sharenet-aspnet",
                    LiveUrl = "www.sharenet.col",
                    Tags = new List<Tag> {Tag.CSHARP, Tag.MVC, Tag.HTML, Tag.CSS, Tag.JS},
                    Featured = true
                },
                new Project
                {
                    ImageUrl = "https://external-content.duckduckgo.com/iu/?u=http%3A%2F%2F4.bp.blogspot.com%2F-Jx21kNqFSTU%2FUXemtqPhZCI%2FAAAAAAAAh74%2FBMGSzpU6F48%2Fs1600%2Ffunny-cat-pictures-047-001.jpg&f=1&nofb=1",
                    Name = "Isogame",
                    Description = "A javascript browser game where you play as a terrastrial isopod.",
                    GithubUrl = "not found",
                    LiveUrl = "www.isogame.com",
                    Tags = new List<Tag> {Tag.CSHARP, Tag.MVC, Tag.HTML, Tag.CSS, Tag.JS},
                    Featured = false
                }
            };
        }

        public IEnumerable<Project> GetAll => Projects;

        public Project GetProjectById(int projectId)
		{
			return Projects.FirstOrDefault(p => p.ProjectId == projectId);
		}

        // REVIEW: As mentioned, you probably don't need these two methods. If you decide to remove them, make sure
        // to remove them from the interface as well or you'll get compiler errors.
		public IEnumerable<Project> Featured =>
            Projects.Where(p => p.Featured);

		public IEnumerable<Project> Others =>
            Projects.Where(p => !p.Featured);

    }
}
