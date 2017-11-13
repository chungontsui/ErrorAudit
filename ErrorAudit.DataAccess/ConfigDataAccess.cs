using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorAudit.DataAccess
{
	public class ConfigDataAccess
	{
		public ConfigDataAccess()
		{

		}

		#region Error
		public Error GetErrorById(int id)
		{
			try
			{
				using (var db = new dbNZGoodiesEntities())
				{
					return db.Error.FirstOrDefault(e => e.Id == id);
				}
			}
			catch (Exception ex)
			{

				throw new Exception("Fail GetErrorById:" + ex.Message);
			}
		}
		public List<Error> GetError()
		{
			try
			{
				using (var db = new dbNZGoodiesEntities())
				{
					return db.Error.ToList();
				}
			}
			catch (Exception ex)
			{

				throw new Exception("Fail GetError: " + ex.Message);
			}
		}
		public Error AddError(Error NewError)
		{
			try
			{
				using (var context = new dbNZGoodiesEntities())
				{
					context.Error.Add(NewError);
					context.SaveChanges();
				}

				return NewError;
			}
			catch (Exception ex)
			{

				throw new Exception("Fail AddError: " + ex.Message);
			}
		}
		public Error EditError(Error error)
		{
			try
			{
				using (var context = new dbNZGoodiesEntities())
				{
					Error editError = context.Error.FirstOrDefault(e => e.Id == error.Id);
					if (editError != null)
					{
						context.Entry(editError).CurrentValues.SetValues(error);
						context.SaveChanges();
					}
				}

				return error;
			}
			catch (Exception ex)
			{

				throw new Exception("Fail EditError:" + ex.Message);
			}
		}
		public void DeleteError(Error error)
		{
			using (var db = new dbNZGoodiesEntities())
			{
				db.Error.Remove(error);
				db.SaveChanges();
			}
		}
		#endregion

		#region Staff
		public Staff GetStaffById(int id)
		{
			try
			{
				using (var db = new dbNZGoodiesEntities())
				{
					return db.Staff.FirstOrDefault(e => e.Id == id);
				}
			}
			catch (Exception ex)
			{

				throw new Exception("Fail GetStaffById:" + ex.Message);
			}
		}
		public List<Staff> GetStaff()
		{
			try
			{
				using (var db = new dbNZGoodiesEntities())
				{
					return db.Staff.ToList();
				}
			}
			catch (Exception ex)
			{

				throw new Exception("Fail GetStaff: " + ex.Message);
			}
		}
		public Staff AddStaff(Staff NewStaff)
		{
			try
			{
				using (var context = new dbNZGoodiesEntities())
				{
					context.Staff.Add(NewStaff);
					context.SaveChanges();
				}

				return NewStaff;
			}
			catch (Exception ex)
			{

				throw new Exception("Fail AddStaff: " + ex.Message);
			}
		}
		public Staff EditStaff(Staff Staff)
		{
			try
			{
				using (var context = new dbNZGoodiesEntities())
				{
					Staff editStaff = context.Staff.FirstOrDefault(e => e.Id == Staff.Id);
					if (editStaff != null)
					{
						context.Entry(editStaff).CurrentValues.SetValues(Staff);
						context.SaveChanges();
					}
				}

				return Staff;
			}
			catch (Exception ex)
			{

				throw new Exception("Fail EditStaff:" + ex.Message);
			}
		}
		public void DeleteStaff(Staff Staff)
		{
			using (var db = new dbNZGoodiesEntities())
			{
				db.Staff.Remove(Staff);
				db.SaveChanges();
			}
		}
		#endregion

		#region Organization
		public Organization GetOrganizationById(int id)
		{
			try
			{
				using (var db = new dbNZGoodiesEntities())
				{
					return db.Organization.FirstOrDefault(e => e.Id == id);
				}
			}
			catch (Exception ex)
			{

				throw new Exception("Fail GetOrganizationById:" + ex.Message);
			}
		}
		public List<Organization> GetOrganization()
		{
			try
			{
				using (var db = new dbNZGoodiesEntities())
				{
					return db.Organization.ToList();
				}
			}
			catch (Exception ex)
			{

				throw new Exception("Fail GetOrganization: " + ex.Message);
			}
		}
		public Organization AddOrganization(Organization NewOrganization)
		{
			try
			{
				using (var context = new dbNZGoodiesEntities())
				{
					context.Organization.Add(NewOrganization);
					context.SaveChanges();
				}

				return NewOrganization;
			}
			catch (Exception ex)
			{

				throw new Exception("Fail AddOrganization: " + ex.Message);
			}
		}
		public Organization EditOrganization(Organization Organization)
		{
			try
			{
				using (var context = new dbNZGoodiesEntities())
				{
					Organization editOrganization = context.Organization.FirstOrDefault(e => e.Id == Organization.Id);
					if (editOrganization != null)
					{
						context.Entry(editOrganization).CurrentValues.SetValues(Organization);
						context.SaveChanges();
					}
				}

				return Organization;
			}
			catch (Exception ex)
			{

				throw new Exception("Fail EditOrganization:" + ex.Message);
			}
		}
		public void DeleteOrganization(Organization Organization)
		{
			using (var db = new dbNZGoodiesEntities())
			{
				db.Organization.Remove(Organization);
				db.SaveChanges();
			}
		}
		#endregion

		#region Outcome
		public Outcome GetOutcomeById(int id)
		{
			try
			{
				using (var db = new dbNZGoodiesEntities())
				{
					return db.Outcome.FirstOrDefault(e => e.Id == id);
				}
			}
			catch (Exception ex)
			{

				throw new Exception("Fail GetOutcomeById:" + ex.Message);
			}
		}
		public List<Outcome> GetOutcome()
		{
			try
			{
				using (var db = new dbNZGoodiesEntities())
				{
					return db.Outcome.ToList();
				}
			}
			catch (Exception ex)
			{

				throw new Exception("Fail GetOutcome: " + ex.Message);
			}
		}
		public Outcome AddOutcome(Outcome NewOutcome)
		{
			try
			{
				using (var context = new dbNZGoodiesEntities())
				{
					context.Outcome.Add(NewOutcome);
					context.SaveChanges();
				}

				return NewOutcome;
			}
			catch (Exception ex)
			{

				throw new Exception("Fail AddOutcome: " + ex.Message);
			}
		}
		public Outcome EditOutcome(Outcome Outcome)
		{
			try
			{
				using (var context = new dbNZGoodiesEntities())
				{
					Outcome editOutcome = context.Outcome.FirstOrDefault(e => e.Id == Outcome.Id);
					if (editOutcome != null)
					{
						context.Entry(editOutcome).CurrentValues.SetValues(Outcome);
						context.SaveChanges();
					}
				}

				return Outcome;
			}
			catch (Exception ex)
			{

				throw new Exception("Fail EditOutcome:" + ex.Message);
			}
		}
		public void DeleteOutcome(Outcome Outcome)
		{
			using (var db = new dbNZGoodiesEntities())
			{
				db.Outcome.Remove(Outcome);
				db.SaveChanges();
			}
		}
		#endregion

		#region ErrorEntry
		public ErrorEntry GetErrorEntryById(int id)
		{
			try
			{
				using (var db = new dbNZGoodiesEntities())
				{
					return db.ErrorEntry.FirstOrDefault(e => e.Id == id);
				}
			}
			catch (Exception ex)
			{

				throw new Exception("Fail GetErrorEntryById:" + ex.Message);
			}
		}
		public List<ErrorEntry> GetErrorEntry()
		{
			try
			{
				using (var db = new dbNZGoodiesEntities())
				{
					return db.ErrorEntry.ToList();
				}
			}
			catch (Exception ex)
			{

				throw new Exception("Fail GetErrorEntry: " + ex.Message);
			}
		}
		public ErrorEntry AddErrorEntry(ErrorEntry NewErrorEntry)
		{
			try
			{
				using (var context = new dbNZGoodiesEntities())
				{
					context.ErrorEntry.Add(NewErrorEntry);
					context.SaveChanges();
				}

				return NewErrorEntry;
			}
			catch (Exception ex)
			{

				throw new Exception("Fail AddErrorEntry: " + ex.Message);
			}
		}
		public ErrorEntry EditErrorEntry(ErrorEntry ErrorEntry)
		{
			try
			{
				using (var context = new dbNZGoodiesEntities())
				{
					ErrorEntry editErrorEntry = context.ErrorEntry.FirstOrDefault(e => e.Id == ErrorEntry.Id);
					if (editErrorEntry != null)
					{
						context.Entry(editErrorEntry).CurrentValues.SetValues(ErrorEntry);
						context.SaveChanges();
					}
				}

				return ErrorEntry;
			}
			catch (Exception ex)
			{

				throw new Exception("Fail EditErrorEntry:" + ex.Message);
			}
		}
		public void DeleteErrorEntry(ErrorEntry ErrorEntry)
		{
			using (var db = new dbNZGoodiesEntities())
			{
				db.ErrorEntry.Remove(ErrorEntry);
				db.SaveChanges();
			}
		}
		#endregion
	}
}
