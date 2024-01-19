using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Website.CoreLayer.DTOs;
using Website.DataLayer.Entities;

namespace Website.CoreLayer.Mapper
{
    public class UserMapper
    {
        public static UserDto Map(User user)
        {
            return new UserDto()
            {
                Id = user.Id,
                Username=user.Username,
                Email=user.Email,
                Password=user.Password,

            };
        }
    }
}
