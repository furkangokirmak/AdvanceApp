using AdvanceAPI.CORE.Utilities;
using AdvanceAPI.DTOs.Status;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAPI.BLL.Abstract
{
	public interface IStatusManager
	{
        Task<Result<StatusSelectDTO>> GetStatusById(int Id);

    }
}
