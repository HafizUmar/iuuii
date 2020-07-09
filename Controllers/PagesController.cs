using BCharityTHeme.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BCharityTHeme.Controllers
{
	public class PagesController : Controller
	{
		// GET: Pages
		DonationDbEntities context = new DonationDbEntities();
		public ActionResult Index()
		{
			return View();
		}

		[HttpGet]
        public ActionResult DonationForm()
        {
            return View();
        }

		//[HttpPost]
		

		public ActionResult TypeChange(string type)
		{

			if (type == "Amount")
			{
				return PartialView("_AmountPV");
			}
			else {
				return PartialView("_OtherTypePV");
			}
		}
			//return View();
		}



		//public ActionResult Contact()
		//{
		//	ViewBag.Message = "Your contact page.";

		//	return View();
		//}
	//}
}