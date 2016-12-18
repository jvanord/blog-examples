using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogExamples.Models
{
	public class UserVm
	{
		private readonly User _user;
		public UserVm(User user) 
		{
			_user = user;
		}

		public string FirstName
		{
			get { return _user.FirstName; } 
			set { _user.FirstName = value; }
		}

		public string LastName
		{
			get { return _user.LastName; }
			set { _user.LastName = value; }
		}
	}

	public class User
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
	}

	public class CreateUserVm
	{
		public Account NewUserAccount { get; set; }
		public Profile NewUserProfile { get; set; }
	}

	public class Account
	{
		public string UserName { get; set; }
		public string Password { get; set; }
	}

	public class Profile
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Address { get; set; }
		public string PhoneNumber { get; set; }
	}

}