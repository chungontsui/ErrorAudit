﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ErrorAudit.DataAccess;
using ErrorAudit.DataAccess.ViewModel;

namespace ErrorAudit.Web.Controllers
{
    public class ErrorAuditController : ApiController
    {
		public void Post(ErrorViewModel error)
		{
			ConfigDataAccess da = new ConfigDataAccess();
			//da.AddErrorEntry(error);
		}
    }
}
