using System;

namespace ShareNet.Models
{
	public class Project
	{
		public string ImageUrl { get; set; }
		public string Name { get; set;}
		public string Description { get; set; }
		public string GitHubUrl { get; set; }
		public string LiveUrl { get; set; }
		public string Tags { get; set; }
		public bool Featured { get; set; }
		public int ProjectId { get; set; }
	}
}
