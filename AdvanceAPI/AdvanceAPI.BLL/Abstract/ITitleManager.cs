using AdvanceAPI.CORE.Utilities;
using AdvanceAPI.DTOs.Title;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdvanceAPI.BLL.Abstract
{
	public interface ITitleManager
	{
		Task<Result<IEnumerable<TitleSelectDTO>>> GetAllTitles();
	}
}
