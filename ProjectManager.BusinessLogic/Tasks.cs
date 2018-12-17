using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManager.DataAccess;


namespace ProjectManager.BusinessLogic
{
    public class Tasks
    {
        TasksDataLayer datalayer = new TasksDataLayer();
        public List<SP_GETALLTASKS1_Result> getAllTasks()
        {
            try
            {
                return datalayer.GetAllTasks();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public tbl_task getTaskById(int taskId)
        {
            try
            {
                return datalayer.GetTask(taskId);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public string UpdateTask(tbl_task taskDetails)
        {
            try
            {
                datalayer.UpdateTask(taskDetails);
                return "Updated";
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public string AddTask(tbl_task newTaskDetails)
        {
            try
            {
                datalayer.CreateTask(newTaskDetails);
                return "Task Created";
                    
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
