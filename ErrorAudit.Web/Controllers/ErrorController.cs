using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ErrorAudit.DataAccess;
using ErrorAudit.DataAccess.ViewModel;

namespace ErrorAudit.Web.Controllers
{
	public class ErrorController : Controller
	{
		private ConfigDataAccess da = new ConfigDataAccess();

		private List<SelectListItem> _errorType;


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


		// GET: Error
		public ActionResult Index()
		{
			List<ErrorViewModel> ev = new List<ErrorViewModel>();

			foreach (Error e in da.GetError())
			{
				ev.Add(new ErrorViewModel() { Id = e.Id, Code = e.ErrorCode, Description = e.ErrorDescription });
			}
			ViewData.Add("ErrorViewModel", ev);

			//List<SelectListItem> errorTypes = new List<SelectListItem>();

			//foreach (ErrorType et in da.GetErrorType())
			//{
			//	errorTypes.Add(new SelectListItem() { Text = et.Description, Value = et.Id.ToString() });
			//}

			//errorTypes.First().Selected = true;

			//ViewData.Add("ErrorTypes", errorTypes);



			//ViewBag.ErrorTypes = SetErrorType();

			return View();
		}

		// GET: Error/Details/5
		public ActionResult Details(int id)
		{
			return View();
		}

		// GET: Error/Create
		public ActionResult Create()
		{

			List<ErrorViewModel> ev = new List<ErrorViewModel>();

			foreach (Error e in da.GetError())
			{
				ev.Add(new ErrorViewModel() { Id = e.Id, Code = e.ErrorCode, Description = e.ErrorDescription });
			}
			ViewData.Add("ErrorViewModel", ev);

			var errorTypes = new List<SelectListItem>();

			foreach (ErrorType et in da.GetErrorType())
			{
				errorTypes.Add(new SelectListItem() { Text = et.Description, Value = et.Id.ToString() });
			}

			ViewBag.ErrorTypes = errorTypes;

			return View();
		}

		// POST: Error/Create
		[HttpPost]
		public ActionResult Create(ErrorViewModel data)
		{

			da.AddError(new Error() { ErrorCode = data.Code, ErrorDescription = data.Description });

			List<ErrorViewModel> ev = new List<ErrorViewModel>();

			foreach (Error e in da.GetError())
			{
				ev.Add(new ErrorViewModel() { Id = e.Id, Code = e.ErrorCode, Description = e.ErrorDescription });
			}
			ViewData.Add("ErrorViewModel", ev);

			ViewBag.ErrorTypes = GetErrorType();

			ViewBag.Model = new ErrorViewModel();

			return View();
		}

		// GET: Error/Edit/5
		public ActionResult Edit(int Id)
		{
			var editError = da.GetErrorById(Id);

			//this.updatingError = new ErrorViewModel() { Id = e.Id, Code = e.ErrorCode, Description = e.ErrorDescription, ErrorType = e.ErrorTypeId == null ? 0 : e.ErrorTypeId.Value};

			//var errorTypes = new List<SelectListItem>();

			//foreach (ErrorType et in da.GetErrorType())
			//{
			//	errorTypes.Add(new SelectListItem() { Text = et.Description, Value = et.Id.ToString() });
			//}

			List<ErrorViewModel> ev = new List<ErrorViewModel>();

			foreach (Error e in da.GetError())
			{
				ev.Add(new ErrorViewModel() { Id = e.Id, Code = e.ErrorCode, Description = e.ErrorDescription });
			}
			ViewData.Add("ErrorViewModel", ev);

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
			
			da.EditError(new Error() { Id = EditError.Id, ErrorDescription = EditError.Description, ErrorCode = EditError.Code,  });
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
