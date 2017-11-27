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
}
