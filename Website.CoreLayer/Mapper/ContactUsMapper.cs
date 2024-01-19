using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Website.CoreLayer.DTOs;
using Website.DataLayer.Entities;

namespace Website.CoreLayer.Mapper
{
    public class ContactUsMapper
    {
        public static ContactUsDto Map(ContactUs product)
        {
            return new ContactUsDto()
            {
                Id = product.Id,
                Name = product.Name,
                Email = product.Email,
                PhoneNumber = product.PhoneNumber,
                Description = product.Description,

            };
        }
    }
}
