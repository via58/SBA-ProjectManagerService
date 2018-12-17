using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProjectManager.BusinessLogic;
using System.Web.Http.Cors;
using ProjectManager.DataAccess;
namespace ProjectManager.ServiceLayer.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class TaskController : ApiController
    {
        Tasks task = new Tasks();
        // GET: api/Task
        public IHttpActionResult GetAllTasks()
        {
            try
            {
                var response = task.getAllTasks();
                if (response != null) return Ok(response);
                else return NotFound();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // POST: api/Task

        public IHttpActionResult PostTask(tbl_task newTaskDetails)
        {
            try
            {
                task.AddTask(newTaskDetails);
                return Ok("Task Added");
            }
            catch (Exception ex)
            {
                throw ex;

            }

        }

        // PUT: api/Task
        
        public IHttpActionResult PutTaskDetail( int id, tbl_task taskDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != taskDetail.task_id)
            {
                return BadRequest();
            }

            try
            {
                task.UpdateTask(taskDetail);
                return Ok("Updated");

            }
            catch (Exception ex)
            {
                throw ex;

            }


        }


    }
}
