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
	public class AdvanceDAL : BaseDAL, IAdvanceDAL
	{
		public AdvanceDAL(IDbConnection connection, IDbTransaction transaction) : base(connection, transaction)
		{
		}

        public async Task<Advance> AddAdvance(Advance advance)
        {
            string query = @"INSERT INTO Advance(AdvanceAmount, AdvanceDescription, ProjectID, DesiredDate, RequestDate, StatusID, EmployeeID) values (@AdvanceAmount, @AdvanceDescription, @ProjectID, @DesiredDate, @RequestDate, @StatusID, @EmployeeID);
              SELECT SCOPE_IDENTITY();";

            var parameters = new
            {
                advance.AdvanceAmount,
                advance.AdvanceDescription,
                advance.ProjectId,
                advance.DesiredDate,
                advance.RequestDate,
                advance.StatusId,
                advance.EmployeeId
            };

            int AdvanceId = await Connection.ExecuteScalarAsync<int>(query, parameters, Transaction);

            string queryHistory = @"INSERT INTO AdvanceHistory(StatusID, AdvanceID, TransactorID, ApprovedAmount, Date) values (@StatusID, @AdvanceID, @TransactorID, @ApprovedAmount, @Date)";

            AdvanceHistory firstHistory = advance.AdvanceHistories.First();
            var StatusId = 201;
            var Date = DateTime.Now;

            var historyParameters = new 
            {
                StatusId,
                AdvanceId,
                firstHistory.TransactorId,
                firstHistory.ApprovedAmount,
                Date
            };

            int rowsAffected = await Connection.ExecuteAsync(queryHistory, historyParameters, Transaction);



            return advance;
        }
    }
}
