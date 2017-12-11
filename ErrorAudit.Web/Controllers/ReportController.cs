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
			ViewBag.AllErrors = DA.GetError();

            return View();
        }
    }
}