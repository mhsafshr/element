using Microsoft.AspNetCore.Mvc;
using Website.CoreLayer.Services.ContactUs;

namespace WebSite.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class HomeController : Controller
	{
		private readonly IContactUsService _contactUsService;
        public HomeController(IContactUsService contactUsService)
        {
            _contactUsService = contactUsService;
        }
        public IActionResult Index()
		{
            return View(_contactUsService.GetAllMessages());
        }
	}
}
