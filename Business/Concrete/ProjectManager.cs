using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProjectManager : IProjectService
    {
        IProject _project;

        public ProjectManager(IProject project)
        {
            _project = project;
        }

        public Project GetByID(int id)
        {
            return _project.GetByID(id);
        }

        public List<Project> LastThreeProject()
        {
            return _project.GetAll().TakeLast(3).ToList();
        }

        public void TAdd(Project t)
        {
            _project.Insert(t);
        }

        public void TDelete(Project t)
        {
            _project.Delete(t);
        }

        public List<Project> TGetAll()
        {
            return _project.GetAll();
        }

        public List<Project> TGetAllByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Project t)
        {
            _project.Update(t);
        }
    }
}
