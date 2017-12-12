using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ErrorAudit.DataAccess;
using ErrorAudit.DataAccess.ViewModel;
using ErrorAudit.Context.Entities;

namespace ErrorAudit.Web.Controllers
{
    public class ErrorAuditController : ApiController
    {
		private ConfigDataAccess da;

		public ErrorAuditController()
		{
			da = new ConfigDataAccess();
		}

		public void Post(ErrorEntryViewModel error)
		{
			da.AddErrorViewModel(error);
		}

		//public IEnumerable<ErrorEntryViewModel> Get()
		//{
		//	return da.GetErrorEntryViewModel();
		//}
	}
}
