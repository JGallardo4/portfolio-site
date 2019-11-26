using System;
using System.Collections.Generic;
using System.Linq;

namespace Portfolio.Models
{
	/// <summary>
	/// Represents a project I have built
	/// to showcase my skills to potential
	/// employers
	/// </summary>
	public class Project
	{
		public string ImageUrl { get; set; }
		public string Name { get; set;}
		public string Description { get; set; }
		public string GithubUrl { get; set; }
		public string LiveUrl { get; set; }
		public IEnumerable<Tag> Tags { get; set; }
		public bool Featured { get; set; }
		public int ProjectId { get; set; }
	}
}
