using AdvanceAPI.Entities.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdvanceAPI.DAL.Repositories.Abstract
{
	public interface IPageDAL
	{
        Task<IEnumerable<Page>> GetPagesWithSelectAuthorization(int titleId);
    }
}
