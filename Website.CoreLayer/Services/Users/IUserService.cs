using CodeYad_Blog.CoreLayer.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Website.CoreLayer.DTOs;

namespace Website.CoreLayer.Services.Users
{
	public interface IUserService
	{
		OperationResult RegisterUser(UserRegisterDTo registerDTo);
		UserDto LoginUser(SignInUserDTO loginDto);
		List<UserDto> GetUsers();
	}
}
