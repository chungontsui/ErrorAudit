using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ErrorAudit.DataAccess;

namespace ErrorAudit.Web.Controllers
{
    public class ErrorsController : ApiController
    {
		private ConfigDataAccess da = new ConfigDataAccess();

        // GET: api/Errors
        public IEnumerable<Error> GetError()
        {
			return da.GetError();
        }

        // GET: api/Errors/5
        [ResponseType(typeof(Error))]
        public IHttpActionResult GetError(int id)
        {
			Error error = da.GetErrorById(id);
            if (error == null)
            {
                return NotFound();
            }

            return Ok(error);
        }

        // PUT: api/Errors/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutError(int id, Error error)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != error.Id)
            {
                return BadRequest();
            }

			//db.Entry(error).State = EntityState.Modified;

			da.EditError(error);


            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Errors
        [ResponseType(typeof(Error))]
        public IHttpActionResult PostError(Error error)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

			da.AddError(error);

            return CreatedAtRoute("DefaultApi", new { id = error.Id }, error);
        }

        // DELETE: api/Errors/5
        [ResponseType(typeof(Error))]
        public IHttpActionResult DeleteError(int id)
        {
			var error = da.GetErrorById(id);
			if (error == null)
			{
				return BadRequest("Delete Error Doesn't Exist");
			}
			else
			{
				da.DeleteError(error);
			}

            return Ok(error);
        }

    }
}