using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ErrorAudit.DataAccess;

namespace ErrorAudit.Web.Controllers
{
    public class ErrorAuditController : ApiController
    {
		public void Post(ErrorEntry error)
		{
			ConfigDataAccess da = new ConfigDataAccess();
			da.AddErrorEntry(error);
		}
    }
}
