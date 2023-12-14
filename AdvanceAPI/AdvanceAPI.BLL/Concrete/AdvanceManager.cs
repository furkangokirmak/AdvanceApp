using AdvanceAPI.BLL.Abstract;
using AdvanceAPI.BLL.Mapper;
using AdvanceAPI.CORE.Helper;
using AdvanceAPI.CORE.Utilities;
using AdvanceAPI.DAL.UnitOfWork;
using AdvanceAPI.DTOs.Advance;
using AdvanceAPI.DTOs.Employee;
using AdvanceAPI.DTOs.Title;
using AdvanceAPI.Entities.Entity;
using AdvanceAPI.ExceptionHandling.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAPI.BLL.Concrete
{
	public class AdvanceManager : IAdvanceManager
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly MyMapper _mapper;

		public AdvanceManager(IUnitOfWork unitOfWork, MyMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}

        public async Task<Result<AdvanceInsertDTO>> AddAdvance(AdvanceInsertDTO advanceInsertDTO)
        {
            var mappedAdvance = _mapper.Map<AdvanceInsertDTO, Advance>(advanceInsertDTO);

            _unitOfWork.BeginTransaction();

			var advance = await _unitOfWork.AdvanceDAL.AddAdvance(mappedAdvance);

			_unitOfWork.Commit();

			return Result<AdvanceInsertDTO>.Success(advanceInsertDTO);
        }

        public async Task<Result<IEnumerable<AdvanceSelectDTO>>> GetEmployeeAdvances(int employeeId)
		{
			var advances = await _unitOfWork.AdvanceDAL.GetEmployeeAdvances(employeeId);
			if (advances == null)
				throw new Exception("Geçmiş bulunamadı");

            var mappedAdvances = _mapper.Map<IEnumerable<Advance>, IEnumerable<AdvanceSelectDTO>>(advances);

			return Result<IEnumerable<AdvanceSelectDTO>>.Success(mappedAdvances);

        }
    }
}
