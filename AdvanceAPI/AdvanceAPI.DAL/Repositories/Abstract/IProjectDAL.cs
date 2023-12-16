using AdvanceAPI.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAPI.DAL.Repositories.Abstract
{
	public interface IProjectDAL
	{
        Task<IEnumerable<Project>> GetAllProjects();
        Task<Project> GetProjectById(int Id);
        Task<IEnumerable<Project>> GetProjectsByEmployeeID(int id);

    }
}
