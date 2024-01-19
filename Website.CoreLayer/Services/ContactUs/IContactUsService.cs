using CodeYad_Blog.CoreLayer.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Website.CoreLayer.DTOs;

namespace Website.CoreLayer.Services.ContactUs
{
    public interface IContactUsService
    {
        OperationResult AddMessage(AddContactUsDto AddDto);
        List<ContactUsDto> GetAllMessages();

    }
}
