using System.Collections.Generic;
using Portfolio.Models;

namespace Portfolio.Repositories
{
    /// <summary>
    /// Specifies the functionality
		/// of the container of the list of
		/// projects I have made.
    /// </summary>
	public interface IProjectRepository
	{
		IEnumerable<Project> GetAll { get; }
	}
}
