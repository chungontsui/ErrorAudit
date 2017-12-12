using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ErrorAudit.DataAccess.ViewModel;
using ErrorAudit.Context;
using ErrorAudit.Context.Entities;

namespace ErrorAudit.DataAccess
{
	public class ConfigDataAccess
	{
		private string ConnStr;

		public ConfigDataAccess(string connStr = null)
		{
			ConnStr = connStr;
		}

		#region Error
		public Error GetErrorById(int id)
		{
			try
			{
				using (var db = new MainContext(ConnStr))
				{
					return db.Errors.FirstOrDefault(e => e.Id == id);
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
				using (var db = new MainContext(ConnStr))
				{
					return db.Errors.ToList();
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
				using (var context = new MainContext(ConnStr))
				{
					context.Errors.Add(NewError);
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
				using (var context = new MainContext(ConnStr))
				{
					Error editError = context.Errors.FirstOrDefault(e => e.Id == error.Id);
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
			using (var db = new MainContext(ConnStr))
			{
				db.Errors.Remove(error);
				db.SaveChanges();
			}
		}
		#endregion

		#region ErrorType
		public IEnumerable<ErrorType> GetErrorType()
		{
			using (var context = new MainContext(ConnStr))
			{
				return context.ErrorTypes.ToList();
			}
		}
		#endregion

		#region Staff
		public Staff GetStaffById(int id)
		{
			try
			{
				using (var db = new MainContext(ConnStr))
				{
					return db.Staffs.FirstOrDefault(e => e.Id == id);
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
				using (var db = new MainContext(ConnStr))
				{
					return db.Staffs.ToList();
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
				using (var context = new MainContext(ConnStr))
				{
					context.Staffs.Add(NewStaff);
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
				using (var context = new MainContext(ConnStr))
				{
					Staff editStaff = context.Staffs.FirstOrDefault(e => e.Id == Staff.Id);
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
			using (var db = new MainContext(ConnStr))
			{
				db.Staffs.Remove(Staff);
				db.SaveChanges();
			}
		}
		#endregion

		#region Organization
		public Organization GetOrganizationById(int id)
		{
			try
			{
				using (var db = new MainContext(ConnStr))
				{
					return db.Organizations.FirstOrDefault(e => e.Id == id);
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
				using (var db = new MainContext(ConnStr))
				{
					return db.Organizations.ToList();
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
				using (var context = new MainContext(ConnStr))
				{
					context.Organizations.Add(NewOrganization);
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
				using (var context = new MainContext(ConnStr))
				{
					Organization editOrganization = context.Organizations.FirstOrDefault(e => e.Id == Organization.Id);
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
			using (var db = new MainContext(ConnStr))
			{
				db.Organizations.Remove(Organization);
				db.SaveChanges();
			}
		}
		#endregion

		#region Outcome
		public Outcome GetOutcomeById(int id)
		{
			try
			{
				using (var db = new MainContext(ConnStr))
				{
					return db.Outcomes.FirstOrDefault(e => e.Id == id);
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
				using (var db = new MainContext(ConnStr))
				{
					return db.Outcomes.ToList();
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
				using (var context = new MainContext(ConnStr))
				{
					context.Outcomes.Add(NewOutcome);
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
				using (var context = new MainContext(ConnStr))
				{
					Outcome editOutcome = context.Outcomes.FirstOrDefault(e => e.Id == Outcome.Id);
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
			using (var db = new MainContext(ConnStr))
			{
				db.Outcomes.Remove(Outcome);
				db.SaveChanges();
			}
		}
		#endregion

		#region ErrorEntry
		public ErrorEntry GetErrorEntryById(int id)
		{
			try
			{
				using (var db = new MainContext(ConnStr))
				{
					return db.ErrorEntries.FirstOrDefault(e => e.Id == id);
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
				using (var db = new MainContext(ConnStr))
				{
					return db.ErrorEntries.ToList();
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
				using (var context = new MainContext(ConnStr))
				{
					context.ErrorEntries.Add(NewErrorEntry);
					context.SaveChanges();
				}

				return NewErrorEntry;
			}
			catch (Exception ex)
			{

				throw new Exception("Fail AddErrorEntry: " + ex.Message);
			}
		}

		public ErrorEntry AddErrorViewModel(ErrorEntryViewModel NewError)
		{
			ErrorEntry _errorEntry = new ErrorEntry()
			{
				CompletedStaffId = NewError.CompletedByStaffId,
				NoticedStaffChecked = NewError.NoticedStaffChecked,
				CreatedDate = DateTime.Now,
				NoticedStaffDispensing = NewError.NoticedStaffDispensing,
				NoticedStaffEnter = NewError.NoticedStaffEnter,
				OrganizationId = 9999,
				OutcomeId = NewError.OutcomeId,
				ProcessingStaffChecked = NewError.ProcessingStaffChecked,
				ProcessingStaffDispensing = NewError.ProcessingStaffDispensing,
				ProcessingStaffEnter = NewError.ProcessingStaffEnter,
				ScriptNumber = NewError.ScriptNumber
			};

			var newErrorEntry = AddErrorEntry(_errorEntry);

			List<ErrorEntryError> lstEEE = new List<ErrorEntryError>();

			foreach (int errorId in NewError.ErrorIds)
			{
				lstEEE.Add(new ErrorEntryError() { ErrorId = newErrorEntry.Id, ErrorEntryId = errorId });
			}

			AddErrorEntryErrorList(lstEEE);

			try
			{
				return _errorEntry;
			}
			catch (Exception ex)
			{

				throw new Exception("Fail AddErrorEntry: " + ex.Message);
			}
		}

		public IEnumerable<ErrorEntryViewModel> GetErrorEntryViewModel()
		{
			List<ErrorEntryViewModel> output = null;

			using (var context = new MainContext(ConnStr))
			{
				var result = context.ErrorEntries.ToList();

				if (result != null && result.Count > 0)
				{
					output = new List<ErrorEntryViewModel>();

					foreach (ErrorEntry ee in context.ErrorEntries)
					{
						output.Add(new ErrorEntryViewModel()
						{
							ScriptNumber = ee.ScriptNumber,
							ProcessingStaffEnter = ee.ProcessingStaffEnter,
							ProcessingStaffDispensing = ee.ProcessingStaffDispensing,
							ProcessingStaffChecked = ee.ProcessingStaffChecked,
							NoticedStaffEnter = ee.NoticedStaffEnter,
							NoticedStaffDispensing = ee.NoticedStaffDispensing,
							NoticedStaffChecked = ee.NoticedStaffChecked,
							CompletedByStaffId = ee.CompletedStaffId.Value,
							OutcomeId = ee.OutcomeId.Value,
							ErrorIds = GetErrorEntryErrorIdsByErrorId(ee.Id)
						});
					}

					return output;
				}
				else
				{
					return output;
				}

			}
		}

		public ErrorEntry EditErrorEntry(ErrorEntry ErrorEntry)
		{
			try
			{
				using (var context = new MainContext(ConnStr))
				{
					ErrorEntry editErrorEntry = context.ErrorEntries.FirstOrDefault(e => e.Id == ErrorEntry.Id);
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
		public void DeleteErrorEntry(ErrorEntry ErrorEntry, bool OverrideError = true)
		{
			using (var db = new MainContext(ConnStr))
			{
				var deleteEntry = db.ErrorEntries.FirstOrDefault(ee => ee.Id == ErrorEntry.Id);

				if (deleteEntry != null)
				{
					db.ErrorEntries.Remove(ErrorEntry);
					db.SaveChanges();
				}
				else
				{
					if (!OverrideError)
					{
						throw new Exception("DeleteErrorEntry Failed: ErrorEntry to delete is not Found");
					}
				}
			}
		}

		public void DeleteErrorEntryById(int ErrorEntryId, bool OverrideError = true)
		{
			using (var db = new MainContext(ConnStr))
			{
				var deleteEntry = db.ErrorEntries.FirstOrDefault(ee => ee.Id == ErrorEntryId);

				if (deleteEntry != null)
				{
					db.ErrorEntries.Remove(deleteEntry);
					db.SaveChanges();
				}
				else
				{
					if (!OverrideError)
					{
						throw new Exception("DeleteErrorEntry Failed: ErrorEntry to delete is not Found");
					}
				}
			}
		}
		#endregion

		#region ErrorEntryError
		public void AddErrorEntryError(ErrorEntryError errorEntryError)
		{
			using (var context = new MainContext(ConnStr))
			{
				context.ErrorEntryErrors.Add(errorEntryError);
				context.SaveChanges();
			}
		}

		public void AddErrorEntryErrorList(IEnumerable<ErrorEntryError> errorEntryErrors)
		{
			using (var context = new MainContext(ConnStr))
			{
				context.ErrorEntryErrors.AddRange(errorEntryErrors);
				context.SaveChanges();
			}
		}

		public IEnumerable<ErrorEntryError> GetErrorEntryErrorByErrorId(int ErrorId)
		{
			using (var context = new MainContext(ConnStr))
			{
				return context.ErrorEntryErrors.Where(ee => ee.ErrorId == ErrorId).ToList();
			}
		}

		public IEnumerable<int> GetErrorEntryErrorIdsByErrorId(int ErrorId)
		{
			using (var context = new MainContext(ConnStr))
			{
				return context.ErrorEntryErrors.Where(ee => ee.ErrorId == ErrorId).Select(s => s.ErrorEntryId);
			}
		}

		#endregion
	}
}
