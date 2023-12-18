using AdvanceAPI.Entities.Entity;
using System.Collections.Generic;
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
