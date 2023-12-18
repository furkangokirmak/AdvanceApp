using AdvanceAPI.Entities.Entity;
using System.Threading.Tasks;

namespace AdvanceAPI.DAL.Repositories.Abstract
{
	public interface IRuleDAL
	{
        Task<Rule> GetRuleByTitleId(int TitleId);
        Task<Rule> GetRuleByEmployeeId(int empId);
    }
}
