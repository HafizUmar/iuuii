using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BCharityTHeme.Controllers
{
	public class DashboardController : Controller
	{
		// GET: Dashboard
		public ActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public ActionResult UserDashboard()
		{
			return View();
		}
	}
}