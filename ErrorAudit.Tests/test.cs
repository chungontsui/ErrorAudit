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

	}
}

