using System;
using System.Collections.Generic;

namespace Portfolio.Repositories
{
	/// <summary>
	/// A temporary store for my contact details.
	/// To be replaced by an implementation that
	/// makes use of a JSON file.
	/// </summary>
	public class MockContactRepository : IContactRepository
	{
		private readonly IDictionary<string, string> _contactDetails;

		public MockContactRepository()
		{
			_contactDetails = new Dictionary<string, string>();
			_contactDetails.Add("Phone number", "780-862-9404");
			_contactDetails.Add("Email", "juan.gallardo.ab@gmail.com");
		}

		public IDictionary<string, string> ContactDetails => _contactDetails;
	}
}
