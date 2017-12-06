using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ErrorAudit.DataAccess;
using ErrorAudit.DataAccess.ViewModel;

namespace ErrorAudit.Web.Controllers
{
	public class ListError
	{
		public int Id { get; set; }
		public string ErrorCode { get; set; }
		public string ErrorDesc { get; set; }
		public string ErrorType { get; set; }
	}

	public class ErrorController : Controller
	{
		private ConfigDataAccess da = new ConfigDataAccess();

		private List<SelectListItem> _errorType;

		private List<ListError> GetAllErrors()
		{
			List<ListError> ev = new List<ListError>();

			List<SelectListItem> errorTypes = GetErrorType();

			foreach (Error e in da.GetError())
			{
				var _errorType = errorTypes.Where(r => r.Value.Equals(e.ErrorTypeId.ToString(), StringComparison.InvariantCultureIgnoreCase)).FirstOrDefault();
				ev.Add(new ListError() { Id = e.Id, ErrorCode = e.ErrorCode, ErrorDesc = e.ErrorDescription, ErrorType = (_errorType == null ? "":_errorType.Text) });
			}

			return ev;
		}

		private List<SelectListItem> GetErrorType()
		{
			if (_errorType == null)
			{
				_errorType = new List<SelectListItem>();

				foreach (ErrorType et in da.GetErrorType())
				{
					_errorType.Add(new SelectListItem() { Text = et.Description, Value = et.Id.ToString() });
				}
			}

			return _errorType;
		}

		// GET: Error/Create
		public ActionResult Create()
		{
			ViewData.Add("ErrorViewModel", GetAllErrors());

			ViewBag.ErrorTypes = GetErrorType();

			return View();
		}

		// POST: Error/Create
		[HttpPost]
		public ActionResult Create(ErrorViewModel data)
		{

			da.AddError(new Error() { ErrorCode = data.Code, ErrorDescription = data.Description });

			ViewData.Add("ErrorViewModel", GetAllErrors());

			ViewBag.ErrorTypes = GetErrorType();

			ModelState.Clear();

			return View(new ErrorViewModel());
		}

		// GET: Error/Edit/5
		public ActionResult Edit(int Id)
		{
			var editError = da.GetErrorById(Id);

			ViewData.Add("ErrorViewModel", GetAllErrors());

			ViewBag.ErrorTypes = GetErrorType();

			ErrorViewModel editErrorVM = new ErrorViewModel()
			{
				Id = editError.Id,
				Code = editError.ErrorCode,
				Description = editError.ErrorDescription,
				ErrorType = editError.ErrorTypeId
			};

			return View(editErrorVM);
		}
		
		[HttpPost]
		public ActionResult Edit(ErrorViewModel EditError)
		{
			da.EditError(new Error() { Id = EditError.Id, ErrorDescription = EditError.Description, ErrorCode = EditError.Code, ErrorTypeId = EditError.ErrorType });
			return RedirectToAction("Create");
		}

		// GET: Error/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: Error/Delete/5
		[HttpPost]
		public ActionResult Delete(int id, FormCollection collection)
		{
			try
			{
				// TODO: Add delete logic here

				return RedirectToAction("Index");
			}
			catch
			{
				return View();
			}
		}
	}
}
