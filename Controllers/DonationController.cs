using BCharityTHeme.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppHelper;
using System.Data.Entity;

namespace BCharityTHeme.Controllers
{
    public class DonationController : Controller
    {
		DonationDbEntities context = new DonationDbEntities();
		// GET: Donation
		[HttpGet]
		public ActionResult DonationForm()
		{
			//ViewBag.DonationType = DDLHelper.GetDonationTypeList();
			//ViewBag.DonationFor = DDLHelper.GetDonationForList();

			Tbl_Donation dontion = new Tbl_Donation();
			return View(dontion);
		}

		public ActionResult myDonations()
		{
			IEnumerable<Tbl_Donation> _listDonation = new List<Tbl_Donation>();
			_listDonation = context.Tbl_Donation.Where(x=>x.Status=="Not Used").ToList();

			return View(_listDonation);
		}

		public ActionResult myInProgressDonations()
		{
			IEnumerable<Tbl_Donation> _listDonation = new List<Tbl_Donation>();
			_listDonation = context.Tbl_Donation.Where(x => x.Status == "In Progress").ToList();

			return View(_listDonation);
		}

		public ActionResult myReceivedDonations()
		{
			IEnumerable<Tbl_Donation> _listDonation = new List<Tbl_Donation>();
			_listDonation = context.Tbl_Donation.Where(x => x.Status == "Received").ToList();

			return View(_listDonation);
		}


		public void addDonationAmount(Tbl_PayPalPayment model)
		{
			
			model.UserID =Convert.ToInt32(Session["LoginID"]);
			context.Tbl_PayPalPayment.Add(model);

			context.SaveChanges();
			
		}

		public ActionResult DeleteDonation(int? Id)
		{

			if (Id > 0)
			{
				var Donationbyid = context.Tbl_Donation.Where(x => x.ID == Id).FirstOrDefault();
				if (Donationbyid != null)
				{
					context.Entry(Donationbyid).State = EntityState.Deleted;
					context.SaveChanges();
				}
			}
			return RedirectToAction("myDonations");

		}



		public ActionResult AddDonation(Tbl_Donation model)
		{

			model.CreatedBy = "Umar";
			model.Status = "Not Used ";
			model.CreatedDate = DateTime.Now;
			context.Tbl_Donation.Add(model);

			context.SaveChanges();
			return RedirectToAction("myDonations", "Donation");
		}

	}
}