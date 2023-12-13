using AdvanceAPI.CORE.Utilities;
using AdvanceAPI.DTOs.BusinessUnit;
using AdvanceAPI.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAPI.BLL.Abstract
{
	public interface IBusinessUnitManager
	{
		Task<Result<IEnumerable<BusinessUnitSelectDTO>>> GetAllBusinessUnits();
	}
}
