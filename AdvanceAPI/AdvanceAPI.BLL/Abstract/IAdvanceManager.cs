using AdvanceAPI.CORE.Utilities;
using AdvanceAPI.DTOs.Advance;
using AdvanceAPI.DTOs.AdvanceHistory;
using AdvanceAPI.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAPI.BLL.Abstract
{
	public interface IAdvanceManager
	{
        Task<Result<string>> AddAdvance(AdvanceInsertDTO advanceInsertDTO);
        Task<Result<IEnumerable<AdvanceSelectDTO>>> GetEmployeeAdvances(int employeeId);
        Task<Result<IEnumerable<AdvanceHistorySelectDTO>>> GetAdvanceHistory(int advanceId);
        Task<Result<AdvanceSelectDTO>> GetAdvanceById(int advanceId);
        Task<Result<IEnumerable<AdvanceSelectDTO>>> GetPendingAdvance(int employeeId);
        Task<Result<IEnumerable<AdvanceSelectDTO>>> GetPendingReceipt();
        Task<Result<IEnumerable<AdvanceSelectDTO>>> GetPendingPaymentDateAdvance();
        Task<Result<string>> AdvanceRequestAccept(AdvanceHistorySelectDTO adHistory);
        Task<Result<string>> AdvanceRequestReject(AdvanceHistorySelectDTO adHistory);
        Task<Result<string>> AdvanceRequestSetPaymentDate(AdvanceHistorySelectDTO adHistory);
        Task<Result<string>> AdvanceRequestReceipt(AdvanceSelectDTO dto);
        Task<Result<IEnumerable<AdvanceSelectDTO>>> GetAdvanceList(int employeeId);
    }
}
