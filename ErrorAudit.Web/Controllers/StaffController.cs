using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ErrorAudit.DataAccess;
using ErrorAudit.DataAccess.ViewModel;

namespace ErrorAudit.Web.Controllers
{
    public class StaffController : Controller
    {
		private ConfigDataAccess da = new ConfigDataAccess();

		private List<StaffViewModel> GetAllStaff()
		{
			List<StaffViewModel> staffs = new List<StaffViewModel>();

			foreach (Staff s in da.GetStaff())
			{
				staffs.Add(new StaffViewModel() { Id = s.Id, FirstName = s.FirstName, LastName = s.LastName, Initial = s.Initial });
			}

			return staffs;
		}

        // GET: Staff/Create
        public ActionResult Create()
        {
			ViewData.Add("StaffViewModel", GetAllStaff());

            return View();
        }

        // POST: Staff/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(StaffViewModel s)
        {
			da.AddStaff(new Staff() { FirstName = s.FirstName, LastName = s.LastName, Initial = s.Initial });

			ModelState.Clear();

			ViewData.Add("StaffViewModel", GetAllStaff());

			return View();
        }

        // GET: Staff/Edit/5
        public ActionResult Edit(int? id)
        {
			var editStaff = da.GetStaffById((int)id);

			StaffViewModel sv = new StaffViewModel()
			{
				Id = editStaff.Id,
				FirstName = editStaff.FirstName,
				LastName = editStaff.LastName,
				Initial = editStaff.Initial
			};

			ViewData.Add("StaffViewModel", GetAllStaff());

			return View(sv);
        }

        // POST: Staff/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(StaffViewModel UpdateStaff)
        {
			da.EditStaff(new Staff() { Id = UpdateStaff.Id, FirstName = UpdateStaff.FirstName, LastName = UpdateStaff.LastName, Initial = UpdateStaff.Initial });
			return RedirectToAction("Create");
        }

        // GET: Staff/Delete/5
        public ActionResult Delete(int? id)
        {
			//if (id == null)
			//{
			//    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			//}
			//Staff staff = db.Staff.Find(id);
			//if (staff == null)
			//{
			//    return HttpNotFound();
			//}
			return RedirectToAction("Create");
        }

        // POST: Staff/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //Staff staff = db.Staff.Find(id);
            //db.Staff.Remove(staff);
            //db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            //if (disposing)
            //{
            //    db.Dispose();
            //}
            base.Dispose(disposing);
        }
    }
}
