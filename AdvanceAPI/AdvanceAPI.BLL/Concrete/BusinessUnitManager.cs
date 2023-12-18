using AdvanceAPI.BLL.Abstract;
using AdvanceAPI.BLL.Mapper;
using AdvanceAPI.CORE.Utilities;
using AdvanceAPI.DAL.UnitOfWork;
using AdvanceAPI.DTOs.BusinessUnit;
using AdvanceAPI.Entities.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdvanceAPI.BLL.Concrete
{
	public class BusinessUnitManager : IBusinessUnitManager
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly MyMapper _mapper;
		public BusinessUnitManager(IUnitOfWork unitOfWork, MyMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}

		public async Task<Result<IEnumerable<BusinessUnitSelectDTO>>> GetAllBusinessUnits()
		{
			var businessUnits = await _unitOfWork.BusinessUnitDAL.GetAllBusinessUnits();

			var mappedBusinessUnits = _mapper.Map<IEnumerable<BusinessUnit>, IEnumerable<BusinessUnitSelectDTO>>(businessUnits);
			
			return Result<IEnumerable<BusinessUnitSelectDTO>>.Success(mappedBusinessUnits);
		}
	}
}
