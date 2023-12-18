using AdvanceAPI.BLL.Abstract;
using AdvanceAPI.BLL.Mapper;
using AdvanceAPI.CORE.Utilities;
using AdvanceAPI.DAL.UnitOfWork;
using AdvanceAPI.DTOs.Rule;
using AdvanceAPI.Entities.Entity;
using System.Threading.Tasks;

namespace AdvanceAPI.BLL.Concrete
{
	public class RuleManager : IRuleManager
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly MyMapper _mapper;

		public RuleManager(IUnitOfWork unitOfWork, MyMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}

		public async Task<Result<RuleSelectDTO>> GetRuleByTitleId(int TitleId)
		{
			var rule = await _unitOfWork.RuleDAL.GetRuleByTitleId(TitleId);

			var mappedRule = _mapper.Map<Rule, RuleSelectDTO>(rule);

			return Result<RuleSelectDTO>.Success(mappedRule);
        }
    }
}
