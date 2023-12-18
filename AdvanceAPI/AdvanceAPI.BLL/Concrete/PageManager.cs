using AdvanceAPI.BLL.Abstract;
using AdvanceAPI.BLL.Mapper;
using AdvanceAPI.CORE.Utilities;
using AdvanceAPI.DAL.UnitOfWork;
using AdvanceAPI.DTOs.Page;
using AdvanceAPI.Entities.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdvanceAPI.BLL.Concrete
{
	public class PageManager : IPageManager
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly MyMapper _mapper;

		public PageManager(IUnitOfWork unitOfWork, MyMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}

		public async Task<Result<IEnumerable<PageSelectDTO>>> GetPagesWithSelectAuthorization(int titleId)
		{
            var pages = await _unitOfWork.PageDAL.GetPagesWithSelectAuthorization(titleId);

            var mappedPages = _mapper.Map<IEnumerable<Page>, IEnumerable<PageSelectDTO>>(pages);

            return Result<IEnumerable<PageSelectDTO>>.Success(mappedPages);
        }

    }
}
