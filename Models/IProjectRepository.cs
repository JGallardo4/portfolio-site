using System.Collections.Generic;
using System.Linq;

namespace Portfolio.Models
{
	public interface IProjectRepository
	{
		IEnumerable<Project> AllProjects { get; }
		IEnumerable<Project> AllFeatured { get; }
		IEnumerable<Project> AllOthers { get; }
		IEnumerable<Project> AllWithTags() { get; }
		Project GetProjectById(int projectId);
	}
}
