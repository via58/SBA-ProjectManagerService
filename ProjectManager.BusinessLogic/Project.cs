using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using ProjectManager.DataAccess;

namespace ProjectManager.BusinessLogic
{
    public class Project
    {
        public static List<tbl_project> GetAllprojects()
        {
            ProjectDataLayer datalayer = new ProjectDataLayer();
            return datalayer.GetProjectList();
        }
        public static tbl_project GetProjectById(int projectId)
        {
            ProjectDataLayer datalayer = new ProjectDataLayer();
            return datalayer.GetProjectDetailsById(projectId);
        }
        public static void AddProject(tbl_project newProjectDetails)
        {
            ProjectDataLayer datalayer = new ProjectDataLayer();
            datalayer.CreateNewProject(newProjectDetails);
        }
        public static void UpdateProject(tbl_project updatedProjectDetails)
        {
            ProjectDataLayer datalayer = new ProjectDataLayer();
            datalayer.UpdateProjectDetail(updatedProjectDetails);
        }
    }
}
