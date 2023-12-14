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
                RequestDate = DateTime.Now,
                StatusId = 101,
                advance.EmployeeId
            };

            int AdvanceId = await Connection.ExecuteScalarAsync<int>(query, parameters, Transaction);

            string queryHistory = @"INSERT INTO AdvanceHistory(StatusID, AdvanceID, TransactorID, ApprovedAmount, Date) values (@StatusID, @AdvanceID, @TransactorID, @ApprovedAmount, @Date)";

            var historyParameters = new
            {
                StatusId = 201,
                AdvanceId,
                TransactorId = advance.EmployeeId,
                ApprovedAmount = 0,
                Date = DateTime.Now
            };

            int rowsAffected = await Connection.ExecuteAsync(queryHistory, historyParameters, Transaction);

            return advance;
        }

        public async Task<IEnumerable<Advance>> GetEmployeeAdvances(int employeeId)
        {
            string query = @"SELECT a.Id, a.AdvanceAmount, a.AdvanceDescription, a.ProjectID, a.DesiredDate, a.RequestDate, a.StatusID, a.EmployeeID,
	                        p.Id, p.DeterminedPaymentDate,
	                        r.Id, r.ReceiptNo, r.Date, r.isRefundReceipt,
	                        ah.Id, ah.TransactorID, ah.Date, ah.StatusID, ah.ApprovedAmount,
	                        e.Id, e.Name, e.Surname,
	                        t.Id, t.TitleName
                            FROM Advance a
                            LEFT JOIN Payment p on p.AdvanceID=a.Id
                            LEFT JOIN Receipt r on r.AdvanceID=a.Id
	                        LEFT JOIN AdvanceHistory ah on ah.AdvanceID = a.ID
	                        LEFT JOIN Employee e on e.ID = ah.TransactorID
	                        LEFT JOIN Title t on t.ID = e.TitleID
                            WHERE a.EmployeeID = @EmployeeID";

            var advances = new Dictionary<int, Advance>();

            var parameters = new
            {
                EmployeeID = employeeId
            };

            var result = await Connection.QueryAsync<Advance, Payment, Receipt, AdvanceHistory, Employee, Title, Advance>(query , (advance, payment, receipt, advancehistory, transactor, title) =>
            {
                if (!advances.TryGetValue(advance.Id, out Advance advanceEntry))
                {
                    advanceEntry = advance;
                    advanceEntry.Project = new Project();
                    advanceEntry.Status = new Status();
                    advanceEntry.Payments = new List<Payment>();
                    advanceEntry.Receipts = new List<Receipt>();
                    advanceEntry.AdvanceHistories = new List<AdvanceHistory>();
                    advances.Add(advance.Id, advanceEntry);
                }

                if (payment != null && !advanceEntry.Payments.Any(x => x.Id == payment.Id))
                    advanceEntry.Payments.Add(payment);

                if (receipt != null && !advanceEntry.Receipts.Any(x => x.Id == receipt.Id))
                    advanceEntry.Receipts.Add(receipt);

                if (advancehistory != null && advancehistory.TransactorId != employeeId && !advanceEntry.AdvanceHistories.Any(x => x.Id == advancehistory.Id))
                {
                    transactor.Title = title;
                    advancehistory.Transactor = transactor;
                    advanceEntry.AdvanceHistories.Add(advancehistory);
                }

                return advanceEntry;
            }, parameters);

            return advances.Values;
        }
    }
}
