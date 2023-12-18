using AdvanceAPI.CORE.Utilities;
using AdvanceAPI.DTOs.BusinessUnit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdvanceAPI.BLL.Abstract
{
	public interface IBusinessUnitManager
	{
		Task<Result<IEnumerable<BusinessUnitSelectDTO>>> GetAllBusinessUnits();
	}
}
