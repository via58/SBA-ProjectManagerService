using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManager.DataAccess;

namespace ProjectManager.BusinessLogic
{
    public class Users
    {
        UserDataLayer userContext = new UserDataLayer();
        public  List<tbl_users> GetAllUsers()
        {
            try
            {
                return userContext.GetUserList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public  tbl_users GetUserById(int userId)
        {
            try
            {
                return userContext.GetUser(userId);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public  string CreateUser(tbl_users userDetail)
        {
            try
            {
                userContext.AddUser(userDetail);
                return "User Added";
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public  string EditUser(tbl_users userDetail)
        {
            try
            {
                userContext.UpdateUser(userDetail);
                return "User Updated";
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public  string DeleteUser(int userId)
        {
            try
            {
                userContext.DeleteUser(userId);
                return "User Added";
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
