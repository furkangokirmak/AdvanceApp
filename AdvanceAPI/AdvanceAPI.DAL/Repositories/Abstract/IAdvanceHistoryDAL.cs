using AdvanceAPI.Entities.Entity;
using System.Threading.Tasks;

namespace AdvanceAPI.DAL.Repositories.Abstract
{
	public interface IAdvanceHistoryDAL
	{
        Task<bool> AddAdvanceHistory(AdvanceHistory advanceHistory);
        Task<AdvanceHistory> GetAdvanceLastHistory(int advanceId);
        Task<bool> UpdateAdvanceHistoryDone(int historyId, bool state);

    }
}
