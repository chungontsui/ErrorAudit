using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ErrorAudit.DataAccess;

namespace ErrorAudit.Web.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			ConfigDataAccess da = new ConfigDataAccess();
			List<Error> _EntryErrors = new List<Error>() {
				new Error(){ Id = 2, ErrorTypeId = 1, ErrorCode = "", ErrorDescription = "Incorrect Directions" },
				new Error(){ Id = 3, ErrorTypeId = 1, ErrorCode = "", ErrorDescription = "History not checked" },
				new Error(){ Id = 4, ErrorTypeId = 1, ErrorCode = "", ErrorDescription = "Dose innappropriate" },
				new Error(){ Id = 5, ErrorTypeId = 1, ErrorCode = "", ErrorDescription = "Incorrect Brand Choosen" },
				new Error(){ Id = 6, ErrorTypeId = 1, ErrorCode = "", ErrorDescription = "Incorrect Quantity/Period Of Supply" },
				new Error(){ Id = 7, ErrorTypeId = 1, ErrorCode = "", ErrorDescription = "Incorreect Calculations" },

				new Error(){ Id = 7, ErrorTypeId = 2, ErrorCode = "", ErrorDescription = "Incorrect Medicine" },
				new Error(){ Id = 7, ErrorTypeId = 2, ErrorCode = "", ErrorDescription = "Incorrect Strength" },
				new Error(){ Id = 7, ErrorTypeId = 2, ErrorCode = "", ErrorDescription = "Incorrect Quantity" },
				new Error(){ Id = 7, ErrorTypeId = 2, ErrorCode = "", ErrorDescription = "Correct Product Form" },
				new Error(){ Id = 7, ErrorTypeId = 2, ErrorCode = "", ErrorDescription = "Incorrect Brand" },
				new Error(){ Id = 7, ErrorTypeId = 2, ErrorCode = "", ErrorDescription = "Interactions Identified" },
				new Error(){ Id = 7, ErrorTypeId = 2, ErrorCode = "", ErrorDescription = "Dose Inappropriate" },
				new Error(){ Id = 7, ErrorTypeId = 2, ErrorCode = "", ErrorDescription = "Drug Omission" },
				new Error(){ Id = 7, ErrorTypeId = 2, ErrorCode = "", ErrorDescription = "Interactions Identified" },
				new Error(){ Id = 7, ErrorTypeId = 2, ErrorCode = "", ErrorDescription = "Incorrect Patient Supplied" },
				new Error(){ Id = 7, ErrorTypeId = 2, ErrorCode = "", ErrorDescription = "Miscellaneous" }
			};

			ViewData.Add("EntryErrors", _EntryErrors.Where(e => e.ErrorTypeId == 1)); //replaced with adding 

			ViewData.Add("DispensingErrors", _EntryErrors.Where(e => e.ErrorTypeId == 2));

			List<Staff> _Staff = new List<Staff>() {
				new Staff(){ Id = 1, FirstName = "Fiona", LastName = "Ho", OrganizationId = 9999},
				new Staff(){ Id = 2, FirstName = "Leanne", LastName = "", OrganizationId = 9999},
				new Staff(){ Id = 3, FirstName = "Warren", LastName = "Flaunty", OrganizationId = 9999},
				new Staff(){Id = 4, FirstName = "Raf", LastName = "Singh", OrganizationId = 9999},
				new Staff(){Id = 5, FirstName = "Jeff", LastName = "Spearman", OrganizationId = 9999}
			};
			ViewData.Add("Staff", _Staff);

			List<Outcome> _Outcomes = new List<Outcome>() {
				new Outcome(){ Id = 1, OutcomeCode = "", OutcomeDescription = "Fixed Error"},
				new Outcome(){ Id = 2, OutcomeCode = "", OutcomeDescription = "Prescriber Notified"},
				new Outcome(){ Id = 3, OutcomeCode = "", OutcomeDescription = "Dosage Corrected"},
				new Outcome(){ Id = 4, OutcomeCode = "", OutcomeDescription = "Prescription Corrected"}
			};
			ViewData.Add("Outcomes", _Outcomes);
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}