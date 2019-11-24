using System;
using System.Collections.Generic;
using System.Linq;

namespace Portfolio.Models
{
	public class Project
	{
		public string ImageUrl { get; set; }
		public string Name { get; set;}
		public string Description { get; set; }
		public string GithubUrl { get; set; }
		public string LiveUrl { get; set; }
		public IEnumerable<string> Tags { get; set; }
		public bool Featured { get; set; }
		public int ProjectId { get; set; }
	}
}
