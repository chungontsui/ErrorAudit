﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ErrorAudit.DataAccess.ViewModel
{
	public class ErrorViewModel
	{
		[Required(AllowEmptyStrings = true)]
		[Display(Name = "Code")]
		public string Code { get; set; }

		[Required(AllowEmptyStrings = false, ErrorMessage = "Description Can Not Be Empty")]
		[Display(Name = "Description")]
		public string Description { get; set; }

		[Display(Name = "Error Type")]
		public string ErrorType { get; set; }
	}
}