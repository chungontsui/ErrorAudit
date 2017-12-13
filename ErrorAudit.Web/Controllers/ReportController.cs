using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ErrorAudit.DataAccess;
using ErrorAudit.DataAccess.ViewModel;
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
			List<Error> sampleErrorHeadings = new List<Error>();
			sampleErrorHeadings.Add(new Error() { ErrorCode = "", ErrorDescription = "History not checked" });
			sampleErrorHeadings.Add(new Error() { ErrorCode = "", ErrorDescription = "Dose innappropriate" });
			sampleErrorHeadings.Add(new Error() { ErrorCode = "", ErrorDescription = "Incorrect Brand Choosen" });
			sampleErrorHeadings.Add(new Error() { ErrorCode = "", ErrorDescription = "Incorrect Quantity/Period Of Supply" });
			sampleErrorHeadings.Add(new Error() { ErrorCode = "", ErrorDescription = "Incorreect Calculations" });
			sampleErrorHeadings.Add(new Error() { ErrorCode = "", ErrorDescription = "Incorrect Medicine" });
			sampleErrorHeadings.Add(new Error() { ErrorCode = "", ErrorDescription = "Incorrect Strength" });
			sampleErrorHeadings.Add(new Error() { ErrorCode = "", ErrorDescription = "Incorrect Quantity" });
			sampleErrorHeadings.Add(new Error() { ErrorCode = "", ErrorDescription = "Correct Product Form" });
			ViewBag.AllErrors = sampleErrorHeadings;//DA.GetError();

			//var errorEntries = DA.GetErrorEntryReportViewModel();

			List<ErrorEntryReportViewModel> errorEntries = new List<ErrorEntryReportViewModel>();

			//errorEntries = DA.GetErrorEntryReportViewModel();

			errorEntries.Add(new ErrorEntryReportViewModel() {  })

            return View();
        }

		private List<bool> GenerateRandomBoolList(int range)
		{

		}
    }


}