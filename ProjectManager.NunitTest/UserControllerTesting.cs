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
    class UserControllerTesting
    {

        [Test]
        public void shouldReturnAllUserDetails()
        {
            //Arrange
            UsersController TestController = new UsersController();
            //Act
            IHttpActionResult ActionResult = TestController.GetAllUsers();
            var expectedResult = typeof(OkNegotiatedContentResult<List<tbl_users>>);
            //Assert
            Assert.IsInstanceOf(expectedResult, ActionResult);
        }

        [Test]
        public void shouldAddUserAndReturnString()
        {
            //Arrange
            UsersController TestController = new UsersController();

            tbl_users temp = new tbl_users();
            temp.FirstName = "Vijay";
            temp.LastName = "Bhaskar";
            temp.Employee_ID = 543687;
            //Act
            IHttpActionResult ActionResult = TestController.PostUser(temp);
            var expectedResult = typeof(OkNegotiatedContentResult<string>);
            //Assert
            Assert.IsInstanceOf(expectedResult, ActionResult);

        }
        [Test]
        public void shouldUpdateUserAndReturnString()
        {
            //Arrange
            UsersController TestController = new UsersController();

            tbl_users temp = new tbl_users();
            temp.FirstName = "Vijay";
            temp.LastName = "Bhaskar";
            temp.Employee_ID = 543687;
            temp.User_ID = 12;

            //Act
            IHttpActionResult ActionResult = TestController.PutUserDestail(12, temp);

            var expectedResult = typeof(OkNegotiatedContentResult<string>);

            //Assert
            Assert.IsInstanceOf(expectedResult, ActionResult);

        }
        [Test]
        public void shouldDeleteUserAndReturnString()
        {
            //Arrange
            UsersController TestController = new UsersController();

            //Act
            IHttpActionResult ActionResult = TestController.DeleteUser(2019);
            var expectedResult = typeof(OkNegotiatedContentResult<string>);
            //Assert
            Assert.IsInstanceOf(expectedResult, ActionResult);

        }
    }
}
