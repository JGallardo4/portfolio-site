using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfolio.Models.Projects
{
	/// <summary>
	/// Relevant technologies used in the
	/// projects displayed on the site.
	/// </summary>
	public class Tag
	{
		[Required]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int TagId { get; set; }

		[Required]
		[StringLength(100)]
		public string Name { get; set; }

		// Image for use in tag page
		[Required]
		[StringLength(100)]	
		public string ImageUrl { get; set; }
	}
}
