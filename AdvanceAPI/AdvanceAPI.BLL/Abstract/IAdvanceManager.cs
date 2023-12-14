using AdvanceAPI.CORE.Utilities;
using AdvanceAPI.DTOs.Advance;
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

    }
}
