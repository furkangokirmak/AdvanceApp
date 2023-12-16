using AdvanceAPI.DAL.Repositories.Abstract;
using AdvanceAPI.Entities.Entity;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAPI.DAL.Repositories.Concrete
{
	public class AdvanceHistoryDAL : BaseDAL, IAdvanceHistoryDAL
	{
		public AdvanceHistoryDAL(IDbConnection connection, IDbTransaction transaction) : base(connection, transaction)
		{
		}

		public async Task<bool> AddAdvanceHistory(AdvanceHistory advanceHistory)
		{
			string query = @"INSERT INTO AdvanceHistory(StatusID, AdvanceID, TransactorID, ApprovedAmount, Date) values (@StatusID, @AdvanceID, @TransactorID, @ApprovedAmount, @Date)";

            var historyParameters = new
            {
                StatusID = advanceHistory.StatusId,
                AdvanceID = advanceHistory.AdvanceId,
                TransactorID = advanceHistory.TransactorId,
                advanceHistory.ApprovedAmount,
                Date = DateTime.Now
            };

            int rowsAffected = await Connection.ExecuteAsync(query, historyParameters, Transaction);

            return rowsAffected > 0;
        }

        //public async Task<bool> UpdateAdvanceHistoryDone(int historyId, bool state)
        //{
        //    string query = @"UPDATE AdvanceHistory SET isDone=@State WHERE Id = @HistoryId";

        //    var rowsAffected = await Connection.ExecuteAsync(query, new { HistoryId = historyId, State = state }, Transaction);

        //    return rowsAffected > 0;
        //}
    }
}
