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
		[Required]
		public int Id { get; set; }

		
		[Required(AllowEmptyStrings = true)]
		[Display(Name = "Code")]
		public string Code { get; set; }

		[Required(AllowEmptyStrings = false, ErrorMessage = "Description Can Not Be Empty")]
		[Display(Name = "Description")]
		public string Description { get; set; }

		[Display(Name = "Error Type")]
		public int? ErrorType { get; set; }
	}

	public class StaffViewModel
	{
		[Required]
		public int Id { get; set; }

		[Required]
		[Display(Name = "First Name")]
		public string FirstName { get; set; }
		[Display(Name = "Last Name")]
		public string LastName { get; set; }

		public string Initial { get; set; }
	}
}
