using AdvanceAPI.BLL.Mapper;
using AdvanceAPI.DAL.Repositories.Abstract;
using AdvanceAPI.DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAPI.BLL.Concrete
{
	public class EmployeeManager : IEmployeeDAL
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly MyMapper _mapper;

		public EmployeeManager(IUnitOfWork unitOfWork, MyMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}
	}
}
