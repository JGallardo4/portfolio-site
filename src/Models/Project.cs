using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfolio.Models
{
	/// <summary>
	/// Represents a project I have built
	/// to showcase my skills to potential
	/// employers
	/// </summary>
	public class Project
	{
		// Main image to be used in projects grid and individual page
		[Required]
		[StringLength(100)]	
		public string ImageUrl { get; set; }

		[Required]
		[StringLength(100)]	
		public string Name { get; set; }

		// Example: group/company site, game, service, etc.
		[Required]
		[StringLength(100)]	
		public string Type { get; set; }

		// For use in projects grid
		[Required]
		[StringLength(100)]
		public string ShortDescription { get; set; }

		// For use in individual page
		[Required]
		public string LongDescription { get; set; }

		[Required]
		[StringLength(100)]	
		public string SourceCodeUrl { get; set; }

		[Required]
		[StringLength(100)]	
		public string LiveUrl { get; set; }

		// Notable features and technologies in the project
		[Required]
		public IEnumerable<Tag> Tags { get; set; }

		[Required]
		public bool Featured { get; set; }

		[Required]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int ProjectId { get; set; }
	}
}
