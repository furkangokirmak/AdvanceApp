using AdvanceAPI.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAPI.DAL.Repositories.Abstract
{
	public interface IAdvanceDAL
	{
        Task<bool> AddAdvance(Advance advance);
        Task<IEnumerable<Advance>> GetEmployeeAdvances(int employeeId);
        Task<IEnumerable<AdvanceHistory>> GetAdvanceHistory(int advanceId);
        Task<Advance> GetAdvanceById(int advanceId);
        Task<IEnumerable<Advance>> GetPendingAdvance(int employeeId);
        Task<bool> UpdateAdvanceStatus(int advanceId, int statusId);
        Task<IEnumerable<Advance>> GetPendingPaymentDateAdvance();
        Task<IEnumerable<Advance>> GetPendingReceipt();
        Task<IEnumerable<Advance>> GetAdvanceList(int employeeId);
    }
}
