using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.DataAccess
{
    public class ParentDataLayer
    {
        public List<tbl_parent_task> getAllParentTasks()
        {
            
            using (ProjectManagerConnection dbContext=new ProjectManagerConnection())
            {
                return dbContext.tbl_parent_task.ToList();
            }
            
        }
    }
}
