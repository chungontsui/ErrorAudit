using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ErrorAudit.Context.Entities;

namespace ErrorAudit.Context
{
	public class MainContext:DbContext
	{
		public DbSet<Error> Errors { get; set; }
		public DbSet<ErrorEntry> ErrorEntries { get; set; }
		public DbSet<ErrorEntryError> ErrorEntryErrors { get; set; }
		public DbSet<ErrorType> ErrorTypes { get; set; }
		public DbSet<Organization> Organizations { get; set; }
		public DbSet<Outcome> Outcomes { get; set; }
		public DbSet<Staff> Staffs { get; set; }
	}
}
