using System.Collections.Generic;

namespace Portfolio.Models
{
	public interface IProjectRepository
	{
		IEnumerable<Project> AllProjects { get; }
		IEnumerable<Project> AllFeatured { get; }

		Project GetProjectById(int projectId);
	}
}
