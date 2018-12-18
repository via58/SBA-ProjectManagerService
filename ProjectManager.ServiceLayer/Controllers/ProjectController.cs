using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using ProjectManager.BusinessLogic;
using ProjectManager.DataAccess;


namespace ProjectManager.ServiceLayer.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ProjectController : ApiController
    {
        // GET: api/Project
        public IHttpActionResult Gettbl_project()
        {
            try
            {
                var response = Project.GetAllprojects();
                if (response != null) return Ok(response);
                else return NotFound();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // GET: api/Project/5
        [ResponseType(typeof(tbl_project))]
        public IHttpActionResult Gettbl_project(int id)
        {
            try
            {
                var response = Project.GetProjectById(id);
                if (response != null) return Ok(response);
                else return NotFound();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT: api/Project/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Puttbl_project(int id, tbl_project projectDetails)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != projectDetails.Project_id)
            {
                return BadRequest();
            }

            try
            {
                Project.UpdateProject(projectDetails);
                return Ok("Updated");

            }
            catch (Exception ex)
            {
                throw ex;

            }


        }

        // POST: api/Project
        [ResponseType(typeof(tbl_project))]
        public IHttpActionResult Posttbl_project(tbl_project newProjectDetails)
        {
            try
            {
                Project.AddProject(newProjectDetails);
                return Ok("Project Added");
            }
            catch (Exception ex)
            {
                throw ex;

            }

        }

        // DELETE: api/Project/5
        //[ResponseType(typeof(tbl_project))]
        //public IHttpActionResult Deletetbl_project(int id)
        //{
        //    try
        //    {
        //        Project();
        //        return Ok("Project Added");
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;

        //    }
        //}

        protected override void Dispose(bool disposing)
        {
            ProjectManagerConnection db = new ProjectManagerConnection() ;
            if (disposing)
            {
               db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}