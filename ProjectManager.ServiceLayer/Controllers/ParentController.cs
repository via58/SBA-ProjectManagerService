using ProjectManager.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ProjectManager.ServiceLayer.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ParentController : ApiController
    {
        ParentTask ptask = new ParentTask();
        // GET: api/Project
        public IHttpActionResult Gettbl_project()
        {
            try
            {
                var response = ptask.GetAllParentTasks();
                if (response != null) return Ok(response);
                else return NotFound();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

   