using AdvanceAPI.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
