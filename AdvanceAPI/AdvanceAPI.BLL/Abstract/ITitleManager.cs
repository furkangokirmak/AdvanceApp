using AdvanceAPI.CORE.Utilities;
using AdvanceAPI.DTOs.BusinessUnit;
using AdvanceAPI.DTOs.Title;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAPI.BLL.Abstract
{
	public interface ITitleManager
	{
		Task<Result<IEnumerable<TitleSelectDTO>>> GetAllTitles();
	}
}
