using COMP003B.Assignment4.Models;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment4.Controllers
{
	public class TrailsController : Controller
	{
		private static List<Trail> trails = new List<Trail>
		{
			new Trail { Id = 1, Name = "Eagle Peak", Location = "Yosemite", DistanceMiles = 6.5, Difficulty = "Hard" },
			new Trail { Id = 2, Name = "River Walk", Location = "Sequoia", DistanceMiles = 3.2, Difficulty = "Easy" },
			new Trail { Id = 3, Name = "Sunset Ridge", Location = "Kings Canyon", DistanceMiles = 4.8, Difficulty = "Moderate" }
		};
		public IActionResult Index()
		{
			ViewData["Title"] = "Trail List";
			return View(trails);
		}

		public IActionResult Details(int id)
		{
			ViewData["Title"] = "Trail Details";
			var trail = trails.FirstOrDefault(t => t.Id == id);

			if (trail == null)
			{
				return NotFound();
			}
			
			return View(trail);
		}

		public IActionResult Featured(string? slug)
		{
			ViewData["Title"] = "Featured Trail";
			ViewBag.Slug = slug ?? "no-trail-selected";
			return View();
		}
	}
}
