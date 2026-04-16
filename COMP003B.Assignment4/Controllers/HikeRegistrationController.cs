using Microsoft.AspNetCore.Mvc;
using COMP003B.Assignment4.Models;

namespace COMP003B.Assignment4.Controllers
{
	[Route("hikes")]
	public class HikeRegistrationController : Controller
	{
		[HttpGet("register")]
		public IActionResult Register()
		{
			ViewData["Title"] = "Hike Registration";
			return View();
		}

		[HttpPost("register")]
		public IActionResult Register(HikeRegistration registration)
		{
			ViewData["Title"] = "Hike Registration";

			if (!ModelState.IsValid)
			{
				return View(registration);
			}

			return RedirectToAction(nameof(Success), new { id = registration.TrailId });
		}

		[HttpGet("success/{id:int}")]
		public IActionResult Success(int id)
		{
			ViewData["Title"] = "Registration Success";
			ViewBag.TrailId = id;
			return View();
		}
	}
}
