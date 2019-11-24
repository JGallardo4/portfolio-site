using System.Collections.Generic;
using System.Linq;

namespace Portfolio.Models
{
	public interface IProjectRepository
	{
		IEnumerable<Project> GetAll { get; }
		IEnumerable<Project> Featured { get; }
		IEnumerable<Project> Others { get; }
		Project GetProjectById(int projectId);
	}
}
