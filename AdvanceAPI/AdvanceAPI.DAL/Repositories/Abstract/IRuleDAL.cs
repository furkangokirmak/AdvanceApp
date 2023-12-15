using AdvanceAPI.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAPI.DAL.Repositories.Abstract
{
	public interface IRuleDAL
	{
        Task<Rule> GetRuleByTitleId(int TitleId);
        Task<Rule> GetRuleByEmployeeId(int empId);
    }
}
