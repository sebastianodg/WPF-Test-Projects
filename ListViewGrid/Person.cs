using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewGrid
{
	public class Person
	{
		public String FirstName { get; set; }
		public String LastName { get; set; }

		public Person()
		{
			this.FirstName = String.Empty;
			this.LastName = String.Empty;
		}

		public Person(String firstName, String lastName)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
		}
	}
}
