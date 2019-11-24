using System.Collections.Generic;
using System.Linq;

namespace Portfolio.Models
{
	public interface IProjectRepository
	{
		IEnumerable<Project> All { get; }
		IEnumerable<Project> Featured { get; }
		IEnumerable<Project> Others { get; }
		IEnumerable<Project> WithTags(IEnumerable<string> tagsSelected) { get; }
		Project GetProjectById(int projectId);
	}
}
