using System;
using System.Collections.Generic;

namespace Portfolio.Repositories
{
	///<summary>
	///Specifies the functionality of
	///the contact details container.
	///</summary>
	public interface IContactRepository
	{
		IDictionary<string, string> ContactDetails { get; }
	}
}
