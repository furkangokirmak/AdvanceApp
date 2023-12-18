using AdvanceAPI.BLL.Abstract;
using AdvanceAPI.BLL.Mapper;
using AdvanceAPI.CORE.Utilities;
using AdvanceAPI.DAL.UnitOfWork;
using AdvanceAPI.DTOs.Title;
using AdvanceAPI.Entities.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdvanceAPI.BLL.Concrete
{
	public class TitleManager : ITitleManager
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly MyMapper _mapper;
		public TitleManager(IUnitOfWork unitOfWork, MyMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}
		public async Task<Result<IEnumerable<TitleSelectDTO>>> GetAllTitles()
		{
			var titles = await _unitOfWork.TitleDAL.GetAllTitles();

			var mappedTitles = _mapper.Map<IEnumerable<Title>, IEnumerable<TitleSelectDTO>>(titles);

			return Result<IEnumerable<TitleSelectDTO>>.Success(mappedTitles);
		}
	}
}
