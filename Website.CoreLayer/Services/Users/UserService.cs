using CodeYad_Blog.CoreLayer.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Website.CoreLayer.DTOs;
using Website.CoreLayer.Mapper;
using Website.DataLayer.Context;
using Website.DataLayer.Entities;

namespace Website.CoreLayer.Services.Users
{
	public class UserService : IUserService
	{
		private readonly  WebContext _context;
        public UserService(WebContext context)
        {
            _context = context;
        }

        public List<UserDto> GetUsers()
        {
            return _context.Users.Select(user => UserMapper.Map(user)).ToList();
        }

        public UserDto LoginUser(SignInUserDTO loginDto)
		{
			var passwordHashed = loginDto.Password.EncodeToMd5();
			var user=  _context.Users.FirstOrDefault(u=>u.Email==loginDto.Email && u.Password == passwordHashed);
			if (user == null)
			{
				return null;
			}
			else
			{
				var userDto = new UserDto()
				{
					Id = user.Id,
					Username = user.Username,
					Email = user.Email,
					Password = user.Password
				};
				return userDto;
			}
			
			
		}

		public OperationResult RegisterUser(UserRegisterDTo registerDTo)
		{
			var isUserNameExist = _context.Users.Any(u=>u.Username == registerDTo.UserName);
			if (isUserNameExist)
			{
				
				return OperationResult.Error("نام کاربری تکراری است");
				
			}
			else {
			var passwordHash = registerDTo.Password.EncodeToMd5();
			_context.Users.Add(new User
			{
				Username = registerDTo.UserName,
				Email = registerDTo.Email,
				Password = passwordHash,
				Role = UserRole.User,
			}) ;
			_context.SaveChanges();
			return OperationResult.Success();
			}
		}
	}
}
