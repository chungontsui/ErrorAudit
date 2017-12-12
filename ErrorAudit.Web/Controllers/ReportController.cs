using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ErrorAudit.DataAccess;
using ErrorAudit.Context.Entities;


namespace ErrorAudit.Web.Controllers
{
    public class ReportController : Controller
    {
		private ConfigDataAccess DA;

		public ReportController() {
			DA = new ConfigDataAccess();
		}
        // GET: Report
        public ActionResult Index()
        {
			List<Error> sampleErrors = new List<Error>();
			sampleErrors.Add(new Error() { ErrorCode = "", ErrorDescription = "History not checked" });
			sampleErrors.Add(new Error() { ErrorCode = "", ErrorDescription = "Dose innappropriate" });
			sampleErrors.Add(new Error() { ErrorCode = "", ErrorDescription = "Incorrect Brand Choosen" });
			sampleErrors.Add(new Error() { ErrorCode = "", ErrorDescription = "Incorrect Quantity/Period Of Supply" });
			sampleErrors.Add(new Error() { ErrorCode = "", ErrorDescription = "Incorreect Calculations" });
			sampleErrors.Add(new Error() { ErrorCode = "", ErrorDescription = "Incorrect Medicine" });
			sampleErrors.Add(new Error() { ErrorCode = "", ErrorDescription = "Incorrect Strength" });
			sampleErrors.Add(new Error() { ErrorCode = "", ErrorDescription = "Incorrect Quantity" });
			sampleErrors.Add(new Error() { ErrorCode = "", ErrorDescription = "Correct Product Form" });
			ViewBag.AllErrors = sampleErrors;//DA.GetError();

			var errorEntries = DA.GetErrorEntryViewModel();



            return View();
        }
    }


}