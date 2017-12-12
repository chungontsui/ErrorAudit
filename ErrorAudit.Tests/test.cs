using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ErrorAudit.Context.Entities;
using ErrorAudit.Context;
using ErrorAudit.DataAccess;
using NUnit.Framework;

namespace ErrorAudit.Tests
{
	public class test
	{
		private ConfigDataAccess DA;
		public test()
		{
			DA = new ConfigDataAccess("ErrorAuditTest");
		}

		[SetUp]
		public void AddTestData()
		{
			using (var context = new MainContext("ErrorAuditTest"))
			{
				context.Staffs.AddRange(TestData.TestStaff);
				context.ErrorEntries.Add(TestData.TestErrorEntry);
				context.Errors.AddRange(TestData.TestError);
				context.SaveChanges();
			}
		}


		[Test]
		public void CanAddErrorEntry()
		{
			var result = DA.AddErrorEntry(TestData.TestErrorEntry);
			Assert.That(result.Id != 0, "AddErrorEntry is not returning new Id");
		}

		[Test]
		public void CanGetStaffWithIntial()
		{
			var result = DA.GetStaff();

			Assert.That(result.All(s => !string.IsNullOrEmpty(s.Initial)), "Not all returned staff have Initial");
			Assert.That(result.First(s => s.FirstName.Equals("Fiona", StringComparison.InvariantCultureIgnoreCase)).Initial.Equals("FSZH", StringComparison.InvariantCulture), "Fiona's Initial is not FSZH as entered");
			Assert.That(result.Count == 3, "Number of staff returned is not 3 but " + result.Count.ToString());
		}

		[Test]
		public void CanGetAllErrorsSortedById()
		{
			var allErrors = DA.GetError();


			Assert.That(allErrors.First().Id == allErrors.Min(e => e.Id), "First Error On the List is not one with smallest id");
			Assert.That(allErrors.Last().Id == allErrors.Max(e => e.Id), "Last Error On the List is not one with largest id");
		}

		[Test]
		public void CanConvertErrorIdsToBoolList()
		{
			var allErrors = DA.GetError();

			int[] errorIds = { allErrors[1].Id, allErrors[3].Id };

			var result = DA.ConvertErrorIdListToBoolList(errorIds);

			Assert.That(allErrors.Count.Equals(result.Count()), "Boolean List Return Does Not Have The Same Count as All Errors");
			Assert.That(result.ElementAt(0).Equals(false), "Element at index 0 is Not False");
			Assert.That(result.ElementAt(1).Equals(true), "Element at index 1 is Not True");
			Assert.That(result.ElementAt(2).Equals(false), "Element at index 2 is Not False");
			Assert.That(result.ElementAt(3).Equals(true), "Element at index 3 is Not True");
		}

		[TearDown]
		public void RemoveTestData()
		{
			//DA.DeleteErrorEntry(TestData.TestErrorEntry);
			//??Truncate the ErrorEntry table??
			using (var context = new MainContext("ErrorAuditTest"))
			{
				context.Database.ExecuteSqlCommand("truncate table Staffs");
				context.Database.ExecuteSqlCommand("truncate table ErrorEntryErrors");
			}
		}
	}

	internal class TestData
	{
		internal static ErrorEntry TestErrorEntry
		{
			get
			{
				return new ErrorAudit.Context.Entities.ErrorEntry()
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
			}
		}
		internal static List<Staff> TestStaff
		{
			get
			{
				return new List<Staff>() {
					new Staff() { Id = 1, FirstName = "Chung", LastName = "Tsui" },
					new Staff() { Id = 2, FirstName = "Fiona", LastName = "Ho", Initial = "FSZH"},
					new Staff() { Id = 3, FirstName = "Warran", LastName = "Flaunty"}
				};
			}
		}
		internal static List<Error> TestError
		{
			get
			{
				return new List<Error>() {
					new Error() { ErrorCode = "", ErrorDescription = "Incorrect Medicine" },
					new Error() { ErrorCode = "", ErrorDescription = "Incorrect Strength" },
					new Error() { ErrorCode = "", ErrorDescription = "Incorrect Quantity" },
					new Error() { ErrorCode = "", ErrorDescription = "Correct Product Form" }
				};
			}
		}
	}
}

