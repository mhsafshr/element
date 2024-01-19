using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Website.DataLayer.Entities;

namespace Website.CoreLayer.DTOs
{
	public class UserDto
	{
        public int Id { get; set; }
        public string Username { get; set; }
		
		public string Email { get; set; }
		
		public string Password { get; set; }

		public UserRole Role { get; set; }

	}
}
