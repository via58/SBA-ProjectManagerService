using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ProjectManager.DataAccess
{

    public class TasksDataLayer
    {
        ProjectManagerConnection dbContext;
        public List<tbl_task> GetAllTasks()
        {
            using (dbContext = new ProjectManagerConnection())
            {
                return dbContext.tbl_task
                                .Include(x => x.tbl_parent_task)
                                .Include(y => y.tbl_project)
                                .Include(z => z.tbl_users)
                                .ToList();

            }
        }

        public tbl_task GetTask(int taskId)
        {
            using (dbContext = new ProjectManagerConnection())
            {
                return dbContext.tbl_task.Find(taskId);
            }
        }
        public void CreateTask(tbl_task newTaskDetails)
        {
            using (dbContext = new ProjectManagerConnection())
            {
                dbContext.tbl_task.Add(newTaskDetails);
                dbContext.SaveChanges();
            }
        }

        public void UpdateTask(tbl_task newTaskDetails)
        {
            using (dbContext = new ProjectManagerConnection())
            {
                dbContext.Entry(newTaskDetails).State = EntityState.Modified;
                dbContext.SaveChanges();
            }
        }


    }
}
