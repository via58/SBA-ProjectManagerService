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
using ProjectManager.DataAccess;

namespace ProjectManager.ServiceLayer.Controllers
{
    public class ParentTaskController : ApiController
    {
        private ProjectManagerEntities db = new ProjectManagerEntities();

        // GET: api/ParentTask
        public IQueryable<tbl_parent_task> Gettbl_parent_task()
        {
            return db.tbl_parent_task;
        }

        // GET: api/ParentTask/5
        [ResponseType(typeof(tbl_parent_task))]
        public IHttpActionResult Gettbl_parent_task(int id)
        {
            tbl_parent_task tbl_parent_task = db.tbl_parent_task.Find(id);
            if (tbl_parent_task == null)
            {
                return NotFound();
            }

            return Ok(tbl_parent_task);
        }

        // PUT: api/ParentTask/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Puttbl_parent_task(int id, tbl_parent_task tbl_parent_task)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbl_parent_task.parent_id)
            {
                return BadRequest();
            }

            db.Entry(tbl_parent_task).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tbl_parent_taskExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/ParentTask
        [ResponseType(typeof(tbl_parent_task))]
        public IHttpActionResult Posttbl_parent_task(tbl_parent_task tbl_parent_task)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tbl_parent_task.Add(tbl_parent_task);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (tbl_parent_taskExists(tbl_parent_task.parent_id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = tbl_parent_task.parent_id }, tbl_parent_task);
        }

        // DELETE: api/ParentTask/5
        [ResponseType(typeof(tbl_parent_task))]
        public IHttpActionResult Deletetbl_parent_task(int id)
        {
            tbl_parent_task tbl_parent_task = db.tbl_parent_task.Find(id);
            if (tbl_parent_task == null)
            {
                return NotFound();
            }

            db.tbl_parent_task.Remove(tbl_parent_task);
            db.SaveChanges();

            return Ok(tbl_parent_task);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tbl_parent_taskExists(int id)
        {
            return db.tbl_parent_task.Count(e => e.parent_id == id) > 0;
        }
    }
}