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
			List<ReportErrorHeading> sampleErrorHeadings = new List<ReportErrorHeading>();
			sampleErrorHeadings.Add(new ReportErrorHeading() { ErrorCode = "", ErrorDescription = "D:History not checked", ErrorType = "Dispensing" });
			sampleErrorHeadings.Add(new ReportErrorHeading() { ErrorCode = "", ErrorDescription = "D:Dose innappropriate", ErrorType = "Dispensing" });
			sampleErrorHeadings.Add(new ReportErrorHeading() { ErrorCode = "", ErrorDescription = "D:Incorrect Brand Choosen", ErrorType = "Dispensing"});
			sampleErrorHeadings.Add(new ReportErrorHeading() { ErrorCode = "", ErrorDescription = "D:Incorrect Quantity/Period Of Supply", ErrorType = "Dispensing"});
			sampleErrorHeadings.Add(new ReportErrorHeading() { ErrorCode = "", ErrorDescription = "E:Incorreect Calculations" , ErrorType = "Entry"});
			sampleErrorHeadings.Add(new ReportErrorHeading() { ErrorCode = "", ErrorDescription = "E:Incorrect Medicine", ErrorType = "Entry"});
			sampleErrorHeadings.Add(new ReportErrorHeading() { ErrorCode = "", ErrorDescription = "E:Incorrect Strength", ErrorType = "Entry"});
			sampleErrorHeadings.Add(new ReportErrorHeading() { ErrorCode = "", ErrorDescription = "E:Incorrect Quantity", ErrorType = "Entry"});
			sampleErrorHeadings.Add(new ReportErrorHeading() { ErrorCode = "", ErrorDescription = "E:Correct Product Form", ErrorType = "Entry"});
			ViewBag.AllErrors = sampleErrorHeadings.OrderByDescending(s => s.ErrorType);
			ViewBag.DispensingErrorCount = sampleErrorHeadings.Count(s => s.ErrorType.Equals("Dispensing", StringComparison.InvariantCultureIgnoreCase));
			ViewBag.EntryErrorCount = sampleErrorHeadings.Count(s => s.ErrorType.Equals("Entry", StringComparison.InvariantCultureIgnoreCase));

			//var errorEntries = DA.GetErrorEntryReportViewModel();

			List<ErrorEntryReportViewModel> errorEntries = new List<ErrorEntryReportViewModel>();

			//errorEntries = DA.GetErrorEntryReportViewModel();

			for (int i = 1; i < 10; i++)
			{
				errorEntries.Add(new ErrorEntryReportViewModel()
				{
					Outcome = "Nailed It",
					ScriptNumber = "456987",
					HasThisError = GenerateRandomBoolList(sampleErrorHeadings.Count),
					ProcessingStaffEnter = "AB",
					ProcessingStaffDispensing = "CD",
					ProcessingStaffChecked = "WF",
					NoticedStaffEnter = "FH",
					NoticedStaffDispensing = "AB",
					NoticedStaffChecked = "JS",
					CompletedByStaff = "AB",
				});
			}

			ViewBag.ErrorEntries = errorEntries;

            return View();
        }

		private List<bool> GenerateRandomBoolList(int range)
		{
			Random r = new Random();
			List<bool> result = new List<bool>();
			for (int i = 0; i < range; i++) {
				result.Add(r.Next(0, 2) == 0?true:false);
			}
			return result;
		}

    }


}