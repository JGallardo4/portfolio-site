using System.Collections.Generic;

namespace Portfolio.ViewModels
{
	///<summary>
	///Transfers data from the repository
	///to the view
	///</summary>
	public class ContactViewModel
	{
		public IDictionary<string, string> ContactDetails { get; set; }
	}
}
