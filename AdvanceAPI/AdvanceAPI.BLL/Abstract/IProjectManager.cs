using AdvanceAPI.CORE.Utilities;
using AdvanceAPI.DTOs.Project;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdvanceAPI.BLL.Abstract
{
	public interface IProjectManager
	{
        Task<Result<IEnumerable<ProjectSelectDTO>>> GetAllProjects();
        Task<Result<ProjectSelectDTO>> GetProjectById(int Id);
        Task<Result<IEnumerable<ProjectSelectDTO>>> GetProjectsByEmployeeID(int id);

    }
}
