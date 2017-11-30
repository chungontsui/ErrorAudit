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
		// GET: Error
		public ActionResult Index()
		{
			List<UpdateErrorViewModel> ev = new List<UpdateErrorViewModel>();

			foreach (Error e in da.GetError())
			{
				ev.Add(new UpdateErrorViewModel() { Id = e.Id, Code = e.ErrorCode, Description = e.ErrorDescription });
			}
			ViewData.Add("ErrorViewModel", ev);

			//List<SelectListItem> errorTypes = new List<SelectListItem>();

			//foreach (ErrorType et in da.GetErrorType())
			//{
			//	errorTypes.Add(new SelectListItem() { Text = et.Description, Value = et.Id.ToString() });
			//}

			//errorTypes.First().Selected = true;

			//ViewData.Add("ErrorTypes", errorTypes);

			var errorTypes = new List<SelectListItem>();

			foreach (ErrorType et in da.GetErrorType())
			{
				errorTypes.Add(new SelectListItem() { Text = et.Description, Value = et.Id.ToString() });
			}

			ViewBag.ErrorTypes = errorTypes;

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
			var errorTypes = new List<SelectListItem>();

			foreach (ErrorType et in da.GetErrorType())
			{
				errorTypes.Add(new SelectListItem() { Text = et.Description, Value = et.Id.ToString() });
			}

			ViewBag.ErrorTypes = errorTypes;

			//errorTypes.First().Selected = true;

			//ViewData.Add("ErrorTypes", errorTypes);
			return View();
		}

		// GET: Error/Create
		//public ActionResult Create(ErrorViewModel EditError)
		//{
		//	ViewBag.EditError = EditError;
		//	return View();
		//}

		// POST: Error/Create
		[HttpPost]
		public ActionResult Create(CreateErrorViewModel data)
		{
			try
			{
				da.AddError(new Error() { ErrorCode = data.Code, ErrorDescription = data.Description });

				return RedirectToAction("Index");
			}
			catch
			{
				return View();
			}
		}

		// GET: Error/Edit/5
		public ActionResult Edit(int Id)
		{
			var editError = da.GetErrorById(Id);
			ViewData.Model = editError;
			return View();
		}
		
		[HttpPost]
		public ActionResult Edit(UpdateErrorViewModel EditError)
		{
			
			da.EditError(new Error() { Id = EditError.Id, ErrorDescription = EditError.Description, ErrorCode = EditError.Code,  });
			return RedirectToAction("Index");
		}

		// POST: Error/Edit/5
		//[HttpPost]
		//public ActionResult Edit(int id, FormCollection collection)
		//{
		//	try
		//	{
		//		// TODO: Add update logic here

		//		return RedirectToAction("Index");
		//	}
		//	catch
		//	{
		//		return View();
		//	}
		//}

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
