using System.Collections.Generic;

using Portfolio.Models;

namespace Portfolio.ViewModels
{
	/// <summary>
	/// Transfers data from the repository to the view.
	/// </summary>
	public class ProjectsListViewModel
	{
		public IEnumerable<Project> Projects { get; set; }
	}
}
