using ProjectManager.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.BusinessLogic
{

    public class ParentTask
    {
        ParentDataLayer datalayer;
        public List<tbl_parent_task> GetAllParentTasks()
        {
            datalayer = new ParentDataLayer();
            try
            {
                return datalayer.getAllParentTasks();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
