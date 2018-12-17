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
    class ProjectControllerTesting
    {

        [Test]
        public void shouldReturnAllProjectDetails()
        {
            //Arrange
            ProjectController TestController = new ProjectController();
            //Act
            IHttpActionResult ActionResult = TestController.Gettbl_project();
            var expectedResult = typeof(OkNegotiatedContentResult<List<SP_GETALLPROJECTSWITHTASK1_Result>>);
            //Assert
            Assert.IsInstanceOf(expectedResult, ActionResult);
        }

        [Test]
        public void shouldAddProjectAndReturnString()
        {
            //Arrange
            ProjectController TestController = new ProjectController();

            tbl_project temp = new tbl_project();
            temp.Project = "Testing Project";
            temp.Priority = "25";
            temp.Start_Date = System.DateTime.Now;
            temp.End_Date = System.DateTime.Now;

            //Act
            IHttpActionResult ActionResult = TestController.Posttbl_project(temp);
            var expectedResult = typeof(OkNegotiatedContentResult<string>);
            //Assert
            Assert.IsInstanceOf(expectedResult, ActionResult);

        }
        [Test]
        public void shouldUpdateProjectAndReturnString()
        {
            //Arrange

            ProjectController TestController = new ProjectController();

            tbl_project temp = new tbl_project();
            temp.Project = "Testing Project has been updated";
            temp.Priority = "25";
            temp.Start_Date = System.DateTime.Now;
            temp.End_Date = System.DateTime.Now;
            temp.Project_id = 1004;

            //Act
            IHttpActionResult ActionResult = TestController.Puttbl_project(1004, temp);

            var expectedResult = typeof(OkNegotiatedContentResult<string>);

            //Assert
            Assert.IsInstanceOf(expectedResult, ActionResult);

        }
    }
}
