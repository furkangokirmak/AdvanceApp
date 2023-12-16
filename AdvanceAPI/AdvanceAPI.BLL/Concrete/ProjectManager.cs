using AdvanceAPI.BLL.Abstract;
using AdvanceAPI.BLL.Mapper;
using AdvanceAPI.CORE.Utilities;
using AdvanceAPI.DAL.UnitOfWork;
using AdvanceAPI.DTOs.Project;
using AdvanceAPI.DTOs.Title;
using AdvanceAPI.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAPI.BLL.Concrete
{
	public class ProjectManager : IProjectManager
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly MyMapper _mapper;

		public ProjectManager(IUnitOfWork unitOfWork, MyMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}

        public async Task<Result<ProjectSelectDTO>> GetProjectById(int Id)
        {
            var project = await _unitOfWork.ProjectDAL.GetProjectById(Id);

            var mappedProject = _mapper.Map<Project, ProjectSelectDTO>(project);

            return Result<ProjectSelectDTO>.Success(mappedProject);
        }

        public async Task<Result<IEnumerable<ProjectSelectDTO>>> GetAllProjects()
        {
            var projects = await _unitOfWork.ProjectDAL.GetAllProjects();

            var mappedProjects = _mapper.Map<IEnumerable<Project>, IEnumerable<ProjectSelectDTO>>(projects);

            return Result<IEnumerable<ProjectSelectDTO>>.Success(mappedProjects);
        }

        public async Task<Result<IEnumerable<ProjectSelectDTO>>> GetProjectsByEmployeeID(int id)
        {
            var projects = await _unitOfWork.ProjectDAL.GetProjectsByEmployeeID(id);

            var mappedProjects = _mapper.Map<IEnumerable<Project>, IEnumerable<ProjectSelectDTO>>(projects);

            return Result<IEnumerable<ProjectSelectDTO>>.Success(mappedProjects);
        }

    }
}
