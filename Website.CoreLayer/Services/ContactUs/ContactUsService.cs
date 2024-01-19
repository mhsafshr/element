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

namespace Website.CoreLayer.Services.ContactUs
{
    public class ContactUsService : IContactUsService
    {
        private readonly WebContext _context;

        public ContactUsService(WebContext context)
        {
            _context = context;
        }
        public OperationResult AddMessage(AddContactUsDto AddDto)
        {
            var message = new DataLayer.Entities.ContactUs()
            {
                Name = AddDto.Name,
                Email = AddDto.Email,
                PhoneNumber = AddDto.PhoneNumber,
                Description = AddDto.Description,
               
            };
            _context.contactUs.Add(message);
            _context.SaveChanges();
            return OperationResult.Success();
        }

        public List<ContactUsDto> GetAllMessages()
        {
            return _context.contactUs.Select(message => ContactUsMapper.Map(message)).ToList();
        }
    }
}
