using System;
using System.Collections.Generic;
using System.Linq;

namespace Portfolio.Models
{
    /// <summary>
    /// REVIEW: Add a description of the class.
    /// </summary>
	public class Project
	{
		public string ImageUrl { get; set; }
		public string Name { get; set;}
		public string Description { get; set; }
		public string GithubUrl { get; set; }
		public string LiveUrl { get; set; }
        // REVIEW: Consider making this a list of enums.
		public IEnumerable<string> Tags { get; set; }
		public bool Featured { get; set; }
		public int ProjectId { get; set; }
	}
}
