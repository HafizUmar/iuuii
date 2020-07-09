using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BCharityTHeme.Models
{
	public class DonationPaymentModel
	{
		Tbl_Donation donation { get; set; }
		Tbl_PayPalPayment paypal { get; set; }
	}
}