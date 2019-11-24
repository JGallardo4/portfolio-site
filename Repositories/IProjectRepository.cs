using System.Collections.Generic;
using System.Linq;
using Portfolio.Models;

namespace Portfolio.Repositories
{
    /// <summary>
    /// REVIEW: Add a description of the interface.
    /// </summary>
	public interface IProjectRepository
	{
		IEnumerable<Project> GetAll { get; }
		IEnumerable<Project> Featured { get; }
		IEnumerable<Project> Others { get; }
		Project GetProjectById(int ProjectId);
	}
}
