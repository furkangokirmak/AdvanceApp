using AdvanceAPI.CORE.Utilities;
using AdvanceAPI.DTOs.Page;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdvanceAPI.BLL.Abstract
{
	public interface IPageManager
	{
        Task<Result<IEnumerable<PageSelectDTO>>> GetPagesWithSelectAuthorization(int titleId);

    }
}
