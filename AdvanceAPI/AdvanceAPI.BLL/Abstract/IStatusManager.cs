using AdvanceAPI.CORE.Utilities;
using AdvanceAPI.DTOs.Status;
using System.Threading.Tasks;

namespace AdvanceAPI.BLL.Abstract
{
	public interface IStatusManager
	{
        Task<Result<StatusSelectDTO>> GetStatusById(int Id);
        Task<Result<StatusSelectDTO>> GetStatusByAdvanceId(int Id);
    }
}
