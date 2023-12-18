using AdvanceAPI.BLL.Abstract;
using AdvanceAPI.BLL.Mapper;
using AdvanceAPI.CORE.Utilities;
using AdvanceAPI.DAL.UnitOfWork;
using AdvanceAPI.DTOs.Status;
using AdvanceAPI.Entities.Entity;
using System.Threading.Tasks;

namespace AdvanceAPI.BLL.Concrete
{
	public class StatusManager : IStatusManager
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly MyMapper _mapper;

		public StatusManager(IUnitOfWork unitOfWork, MyMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}

        public async Task<Result<StatusSelectDTO>> GetStatusById(int Id)
        {
            var status = await _unitOfWork.StatusDAL.GetStatusById(Id);

            var mappedStatus = _mapper.Map<Status, StatusSelectDTO>(status);

            return Result<StatusSelectDTO>.Success(mappedStatus);
        }

        public async Task<Result<StatusSelectDTO>> GetStatusByAdvanceId(int Id)
        {
            var status = await _unitOfWork.StatusDAL.GetStatusByAdvanceId(Id);

            var mappedStatus = _mapper.Map<Status, StatusSelectDTO>(status);

            return Result<StatusSelectDTO>.Success(mappedStatus);
        }
    }
}
