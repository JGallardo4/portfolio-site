namespace ShareNet.Models
{
	public interface IProjectRepository
	{
		IEnumerable<Project> AllProjects { get; }
		IEnumerable<Project> Featured { get; }

		Project GetProjectById(int projectId);
	}
}
