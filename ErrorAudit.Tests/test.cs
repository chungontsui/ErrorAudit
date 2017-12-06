using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ErrorAudit.DataAccess;
using NUnit.Framework;

namespace ErrorAudit.Tests
{
	public class test
	{
		private ConfigDataAccess DA;
		public test()
		{
			DA = new ConfigDataAccess();
		}

		[Test]
		public void CanAddOrganization()
		{
			string orgName = "Test Pharmacy";
			Organization org = new Organization();
			org.OrganizationName = orgName;
			DA.AddOrganization(org);
			var result = DA.GetOrganization().FirstOrDefault(o => o.OrganizationName == orgName);
			Assert.That(result != null, "Can't find the flipping added org!");
			//DA.DeleteOrganization(result);
		}

		[Test]
		public void CanAddErrorEntry()
		{
			ErrorEntry _errorEntry = new ErrorEntry()
			{
				CompletedStaffId = 12345,
				NoticedStaffChecked = 12345,
				CreatedDate = DateTime.Now,
				NoticedStaffDispensing = 12345,
				NoticedStaffEnter = 12345,
				OrganizationId = 9999,
				OutcomeId = 2345,
				ProcessingStaffChecked = 12345,
				ProcessingStaffDispensing = 12345,
				ProcessingStaffEnter = 12345,
				ScriptNumber = "654789"
			};

			var result = DA.AddErrorEntry(_errorEntry);
			Assert.That(result.Id != 0, "AddErrorEntry is not returning new Id");
		}
	}
}

