using AdvanceAPI.CORE.Utilities;
using AdvanceAPI.DTOs.Advance;
using AdvanceAPI.DTOs.AdvanceHistory;
using AdvanceAPI.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAPI.BLL.Abstract
{
	public interface IAdvanceManager
	{
        Task<Result<AdvanceInsertDTO>> AddAdvance(AdvanceInsertDTO advanceInsertDTO);
        Task<Result<IEnumerable<AdvanceSelectDTO>>> GetEmployeeAdvances(int employeeId);
        Task<Result<IEnumerable<AdvanceHistorySelectDTO>>> GetAdvanceHistory(int advanceId);
        Task<Result<AdvanceSelectDTO>> GetAdvanceById(int advanceId);

    }
}
