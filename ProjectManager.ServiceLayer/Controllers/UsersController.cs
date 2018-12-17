using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Http.Cors;
using ProjectManager.BusinessLogic;
using ProjectManager.DataAccess;

namespace ProjectManager.ServiceLayer.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class UsersController : ApiController
    {
        Users users = new Users();
        // GET: api/Users
        public IHttpActionResult GetAllUsers()
        {
            try
            {
                var response = users.GetAllUsers();
                if (response != null) return Ok(response);
                else return NotFound();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // GET: api/Users/5
        [ResponseType(typeof(tbl_users))]
        public IHttpActionResult GetUser(int id)
        {
            try
            {
                var response = users.GetUserById(id);
                if (response != null) return Ok(response);
                else return NotFound();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT: api/Users/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUserDestail(int id, tbl_users userDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != userDetail.User_ID)
            {
                return BadRequest();
            }

            try
            {
                users.EditUser(userDetail);
                return Ok("Updated");

            }
            catch (Exception ex)
            {
                throw ex;

            }


        }

        // POST: api/Users

        public IHttpActionResult PostUser(tbl_users newUserDetails)
        {
            try
            {
                users.CreateUser(newUserDetails);
                return Ok("User Added");
            }
            catch (Exception ex)
            {
                throw ex;

            }

        }

        //DELETE: api/Users/5

        public IHttpActionResult DeleteUser(int id)
        {
            try
            {
                users.DeleteUser(id);
                return Ok("Project Deleted");
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
    }
}
