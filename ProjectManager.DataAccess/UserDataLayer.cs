using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ProjectManager.DataAccess
{
    public class UserDataLayer
    {
        ProjectManagerConnection dbContext;
        public  List<tbl_users> GetUserList()
        {
            using (dbContext = new ProjectManagerConnection())
            {
                return dbContext.tbl_users.ToList();
            }
        }

        public tbl_users GetUser(int UserId)
        {
            using (dbContext = new ProjectManagerConnection())
            {
                return dbContext.tbl_users.Find(UserId);
                   
            }
        }

        public void AddUser(tbl_users userDetail)
        {
            using (dbContext = new ProjectManagerConnection())
            {
                dbContext.tbl_users.Add(userDetail);
                dbContext.SaveChanges();
            }
        }

        public void UpdateUser(tbl_users userDetail)
        {
            using (dbContext = new ProjectManagerConnection())
            {
                dbContext.Entry(userDetail).State = EntityState.Modified;
                dbContext.SaveChanges();
            }
        }

        public void DeleteUser(int UserId)
        {
            using (dbContext = new ProjectManagerConnection())
            {
                var user = dbContext.tbl_users.Find(UserId);
                dbContext.tbl_users.Remove(user);
                dbContext.SaveChanges();
            }
        }
    }
}
