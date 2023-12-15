using AdvanceAPI.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAPI.DAL.Repositories.Abstract
{
	public interface IAdvanceDAL
	{
        Task<Advance> AddAdvance(Advance advance);
        Task<IEnumerable<Advance>> GetEmployeeAdvances(int employeeId);
        Task<IEnumerable<AdvanceHistory>> GetAdvanceHistory(int advanceId);

    }
}
