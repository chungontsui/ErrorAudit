using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorAudit.DataAccess.ViewModel
{
	public class ErrorEntryViewModel
	{
		public string ScriptNumber { get; set; }
		public IEnumerable<int> ErrorIds { get; set; }
		public int ProcessingStaffEnter { get; set; }
		public int ProcessingStaffDispensing { get; set; }
		public int ProcessingStaffChecked { get; set; }
		public int NoticedStaffEnter { get; set; }
		public int NoticedStaffDispensing { get; set; }
		public int NoticedStaffChecked { get; set; }
		public int CompletedByStaffId { get; set; }
		public int OutcomeId { get; set; }
	}

	public class ErrorEntryReportViewModel
	{
		public string ScriptNumber { get; set; }
		public IEnumerable<Boolean> HasThisError { get; set; }
		public string ProcessingStaffEnter { get; set; }
		public string ProcessingStaffDispensing { get; set; }
		public string ProcessingStaffChecked { get; set; }
		public string NoticedStaffEnter { get; set; }
		public string NoticedStaffDispensing { get; set; }
		public string NoticedStaffChecked { get; set; }
		public string CompletedByStaff { get; set; }
		public string Outcome { get; set; }
	}

	public class ReportErrorHeading
	{
		public string ErrorCode { get; set; }
		public string ErrorDescription { get; set; }
		public string ErrorType { get; set; }
	}
}
