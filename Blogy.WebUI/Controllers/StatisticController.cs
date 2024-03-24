using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Controllers
{
	public class StatisticController : Controller
	{

		public IActionResult Index()
		{
			return View();
		}
	}
}
