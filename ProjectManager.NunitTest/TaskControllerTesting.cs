using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManager.ServiceLayer.Controllers;
using System.Web.Http;
using System.Net.Http;
using System.Net;
using System.Web.Http.Results;
using ProjectManager.DataAccess;
using System.Data.Entity;

namespace ProjectManager.NunitTest
{
    [TestFixture]
    public class TaskControllerTesting
    {
        [Test]
        public void shouldReturnAllTasks()
        {
            //Arrange
            TaskController TestController = new TaskController();
            //Act
            IHttpActionResult ActionResult = TestController.GetAllTasks();
            var expectedResult = typeof(OkNegotiatedContentResult<List<SP_GETALLTASKS1_Result>>);
            //Assert
            Assert.IsInstanceOf(expectedResult, ActionResult);
        }

        [Test]
        public void shouldAddTaskAndReturnString()
        {
            //Arrange
            TaskController TestController = new TaskController();

            tbl_task temp = new tbl_task();
            temp.task = "task";
            temp.status = "In Progress";
            temp.parent_id = 0;
            temp.start_date = System.DateTime.Now;
            temp.end_date = System.DateTime.Now;
            temp.priority = 15;
            temp.project_id = 1;
            
            //Act
            IHttpActionResult ActionResult = TestController.PostTask(temp);
            var expectedResult = typeof(OkNegotiatedContentResult<string>);
            //Assert
            Assert.IsInstanceOf(expectedResult, ActionResult);

        }
        [Test]
        public void shouldUpdateTaskAndReturnString()
        {
            //Arrange

            TaskController TestController = new TaskController();

            tbl_task temp = new tbl_task();
            temp.task = "task has been update";
            temp.status = "In Progress";
            temp.parent_id = 0;
            temp.start_date = System.DateTime.Now;
            temp.end_date = System.DateTime.Now;
            temp.priority = 15;
            temp.project_id = 1;
            temp.task_id = 16;

            //Act
            IHttpActionResult ActionResult = TestController.PutTaskDetail(16, temp);

            var expectedResult = typeof(OkNegotiatedContentResult<string>);

            //Assert
            Assert.IsInstanceOf(expectedResult, ActionResult);

        }

    }
}
