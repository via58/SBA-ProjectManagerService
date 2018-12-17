using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;

namespace ProjectManager.DataAccess
{
    public class ProjectDataLayer
    {
        public virtual List<SP_GETALLPROJECTSWITHTASK1_Result> GetProjectList()
        {
            using (ProjectManagerConnection dbContext = new ProjectManagerConnection())
            {
                //  var project = dbContext.GetProjects();
                //return dbContext.tbl_project
                //    .Include(x => x.tbl_task)
                //    .Include(y => y.tbl_users)
                //    .ToList();
                return dbContext.SP_GETALLPROJECTSWITHTASK1().ToList();
            }
        }
        
            
            
            public tbl_project GetProjectDetailsById(int projectId)
        {
            using (ProjectManagerConnection dbContext = new ProjectManagerConnection())

            {
                return dbContext.tbl_project.Find(projectId);
            }
        }

        public void CreateNewProject(tbl_project projectDetails)
        {
            using (ProjectManagerConnection dbContext = new ProjectManagerConnection())
            {
                dbContext.tbl_project.Add(projectDetails);
               // dbContext.Entry(projectDetails).State = EntityState.Added;
                dbContext.SaveChanges();
                

            }
        }
        public void UpdateProjectDetail(tbl_project projectDetails)
        {
            using (ProjectManagerConnection dbContext = new ProjectManagerConnection())
            {
                dbContext.Entry(projectDetails).State = EntityState.Modified;
                dbContext.SaveChanges();
            }
        }


    }
}
