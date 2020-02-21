using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfolio.Models.Projects
{
	/// <summary>
	/// Represents a project I have built
	/// to showcase my skills to potential
	/// employers
	/// </summary>
	public class Project
	{
		[Required]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ProjectId { get; set; }

		// Main image to be used in projects grid and individual page
		[Required]
		[StringLength(100)]	
		public string ImageUrl { get; set; }

		[Required]
		[StringLength(100)]	
		public string Name { get; set; }

		// For use in projects grid
		[Required]
		[StringLength(200)]
		public string Description { get; set; }

		[Required]
		[StringLength(100)]	
		public string SourceCodeUrl { get; set; }

		[Required]
		[StringLength(100)]	
		public string LiveUrl { get; set; }

		[Required]
		public bool Featured { get; set; }		
	}
}
