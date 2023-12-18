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

        public async Task<bool> AddAdvance(Advance advance)
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
                ApprovedAmount = advance.AdvanceAmount,
                Date = DateTime.Now
            };

            int rowsAffected = await Connection.ExecuteAsync(queryHistory, historyParameters, Transaction);

            return rowsAffected > 0;
        }

        public async Task<IEnumerable<Advance>> GetEmployeeAdvances(int employeeId)
        {
            string query = @"SELECT a.Id, a.AdvanceAmount, a.AdvanceDescription, a.ProjectID, a.DesiredDate, a.RequestDate, a.StatusID, a.EmployeeID,
	                        p.Id, p.DeterminedPaymentDate, p.FinanceManagerId,
	                        r.Id, r.ReceiptNo, r.Date, r.isRefundReceipt, r.AccountantId,
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

            var result = await Connection.QueryAsync<Advance, Payment, Receipt, AdvanceHistory, Employee, Title, Advance>(query, (advance, payment, receipt, advancehistory, transactor, title) =>
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

                if (advancehistory != null
                    && advancehistory.TransactorId != employeeId
                    && !advanceEntry.AdvanceHistories.Any(x => x.Id == advancehistory.Id)
                    && ((payment == null) || (advancehistory.TransactorId != payment.FinanceManagerId))
                    && ((receipt == null) || (advancehistory.TransactorId != receipt.AccountantId)))
                {
                    transactor.Title = title;
                    advancehistory.Transactor = transactor;
                    advanceEntry.AdvanceHistories.Add(advancehistory);
                }

                return advanceEntry;
            }, parameters);



            return advances.Values;
        }

        public async Task<Advance> GetAdvanceById(int advanceId)
        {
            string query = @"SELECT a.Id, a.AdvanceAmount, a.AdvanceDescription, a.ProjectID, a.DesiredDate, a.RequestDate, a.StatusID, a.EmployeeID,
	                        p.Id, p.DeterminedPaymentDate, p.FinanceManagerID,
	                        r.Id, r.ReceiptNo, r.Date, r.isRefundReceipt, r.AccountantID,
	                        ah.Id, ah.TransactorID, ah.Date, ah.StatusID, ah.ApprovedAmount,
	                        e.Id, e.Name, e.Surname,
	                        t.Id, t.TitleName
                            FROM Advance a
                            LEFT JOIN Payment p on p.AdvanceID=a.Id
                            LEFT JOIN Receipt r on r.AdvanceID=a.Id
	                        LEFT JOIN AdvanceHistory ah on ah.AdvanceID = a.ID
	                        LEFT JOIN Employee e on e.ID = ah.TransactorID
	                        LEFT JOIN Title t on t.ID = e.TitleID
                            WHERE a.Id = @AdvanceID";

            var advances = new Dictionary<int, Advance>();

            var parameters = new
            {
                AdvanceID = advanceId
            };

            var result = await Connection.QueryAsync<Advance, Payment, Receipt, AdvanceHistory, Employee, Title, Advance>(query, (advance, payment, receipt, advancehistory, transactor, title) =>
            {
                if (!advances.TryGetValue(advance.Id, out Advance advanceEntry))
                {
                    advanceEntry = advance;
                    advanceEntry.Project = new Project();
                    advanceEntry.Status = new Status();
                    advanceEntry.Payments = new List<Payment>();
                    advanceEntry.Receipts = new List<Receipt>();
                    advances.Add(advance.Id, advanceEntry);
                }

                if (payment != null && !advanceEntry.Payments.Any(x => x.Id == payment.Id))
                    advanceEntry.Payments.Add(payment);

                if (receipt != null && !advanceEntry.Receipts.Any(x => x.Id == receipt.Id))
                    advanceEntry.Receipts.Add(receipt);

                return advanceEntry;
            }, parameters);



            return advances.Values.FirstOrDefault();
        }

        public async Task<IEnumerable<AdvanceHistory>> GetAdvanceHistory(int advanceId)
        {
            string query = @"SELECT ah.Id ,ah.Date, ah.ApprovedAmount, ah.TransactorId, a.Id, a.StatusId ,ahs.Id, ahs.StatusName,  e.Id , e.Name, e.Surname, upe.Id, upe.Name, upe.Surname, t.Id , t.TitleDescription
                            FROM AdvanceHistory ah
                            JOIN Advance a on a.ID = ah.AdvanceID
                            JOIN Status ahs on ahs.ID = ah.StatusID 
                            JOIN Employee e on e.ID = ah.TransactorID
                            JOIN Employee upe on upe.ID = e.UpperEmployeeID
                            JOIN Title t on t.ID = upe.TitleID
                            WHERE ah.AdvanceID = @AdvanceID";

            var parameters = new
            {
                AdvanceID = advanceId
            };

            var result = await Connection.QueryAsync<AdvanceHistory, Advance, Status, Employee, Employee, Title, AdvanceHistory>(query, (advancehistory, advance, status, employee, upperemp, title) =>
            {
                advancehistory.Advance = advance;
                advancehistory.Status = status;

                upperemp.Title = title;
                employee.UpperEmployee = upperemp;
                advancehistory.Transactor = employee;

                return advancehistory;
            }, parameters);

            return result;
        }

        public async Task<IEnumerable<Advance>> GetPendingAdvance(int employeeId)
        {
            string query = @"SELECT *
                            from Advance a
                            left join AdvanceHistory ah on ah.AdvanceID = a.ID 
                            left join Employee emp on emp.ID = a.EmployeeID
                            left join Employee temp on temp.ID = ah.TransactorID
                            left join Employee uppertemp on uppertemp.ID = temp.UpperEmployeeID
                            left join Payment p on p.AdvanceID = a.ID
                            left join Receipt r on r.AdvanceID = a.ID
                            WHERE uppertemp.ID=@EmployeeID and a.StatusId=101 and ah.isDone=0";

            var parameters = new
            {
                EmployeeID = employeeId
            };

            var advances = new Dictionary<int, Advance>();

            var result = await Connection.QueryAsync<Advance, AdvanceHistory, Employee, Employee, Employee, Payment, Receipt, Advance>(query, (advance, advancehistory, emp, temp, uppertemp, payment, receipt) =>
            {
                if (!advances.TryGetValue(advance.Id, out Advance advanceEntry))
                {
                    advance.Employee = emp;

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

                if (advancehistory != null
                && !advanceEntry.AdvanceHistories.Any(x => x.Id == advancehistory.Id)
                && ((payment == null) || (advancehistory.TransactorId != payment.FinanceManagerId))
                && ((receipt == null) || (advancehistory.TransactorId != receipt.AccountantId)))
                {
                    temp.UpperEmployee = uppertemp;
                    advancehistory.Transactor = temp;
                    advanceEntry.AdvanceHistories.Add(advancehistory);
                }
                return advance;
            }, parameters);

            return advances.Values;
        }

        public async Task<bool> UpdateAdvanceStatus(int advanceId, int statusId)
        {
            string query = @"UPDATE Advance SET StatusID=@StatusID WHERE Id = @AdvanceId";

            var rowsAffected = await Connection.ExecuteAsync(query, new { AdvanceId = advanceId, StatusID = statusId }, Transaction);

            return rowsAffected > 0;
        }

        public async Task<IEnumerable<Advance>> GetPendingPaymentDateAdvance()
        {
            string query = @"SELECT *
                            from Advance a
                            left join AdvanceHistory ah on ah.AdvanceID = a.ID 
                            left join Employee emp on emp.ID = a.EmployeeID
                            left join Employee temp on temp.ID = ah.TransactorID
                            left join Employee uppertemp on uppertemp.ID = temp.UpperEmployeeID
                            left join Payment p on p.AdvanceID = a.ID
                            left join Receipt r on r.AdvanceID = a.ID
                            WHERE a.StatusId=102";

            var advances = new Dictionary<int, Advance>();

            var result = await Connection.QueryAsync<Advance, AdvanceHistory, Employee, Employee, Employee, Payment, Receipt, Advance>(query, (advance, advancehistory, emp, temp, uppertemp, payment, receipt) =>
            {
                if (payment == null)
                {
                    if (!advances.TryGetValue(advance.Id, out Advance advanceEntry))
                    {
                        advance.Employee = emp;

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

                    if (advancehistory != null
                    && !advanceEntry.AdvanceHistories.Any(x => x.Id == advancehistory.Id)
                    && ((payment == null) || (advancehistory.TransactorId != payment.FinanceManagerId))
                    && ((receipt == null) || (advancehistory.TransactorId != receipt.AccountantId)))
                    {
                        temp.UpperEmployee = uppertemp;
                        advancehistory.Transactor = temp;
                        advanceEntry.AdvanceHistories.Add(advancehistory);
                    }
                }
                return advance;
            });

            return advances.Values;
        }

        public async Task<IEnumerable<Advance>> GetPendingReceipt()
        {
            string query = @"SELECT *
                            from Advance a
                            join AdvanceHistory ah on ah.AdvanceID = a.ID 
                            join Employee emp on emp.ID = a.EmployeeID
                            join Employee temp on temp.ID = ah.TransactorID
                            join Payment p on p.AdvanceID = a.ID
                            left join Receipt r on r.AdvanceID = a.ID
                            WHERE a.StatusId=102";

            var advances = new Dictionary<int, Advance>();

            var result = await Connection.QueryAsync<Advance, AdvanceHistory, Employee, Employee, Payment, Receipt, Advance>(query, (advance, advancehistory, emp, temp, payment, receipt) =>
            {
                if (!advances.TryGetValue(advance.Id, out Advance advanceEntry))
                {
                    advance.Employee = emp;

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

                if (advancehistory != null
                && !advanceEntry.AdvanceHistories.Any(x => x.Id == advancehistory.Id)
                && ((payment == null) || (advancehistory.TransactorId != payment.FinanceManagerId))
                && ((receipt == null) || (advancehistory.TransactorId != receipt.AccountantId)))
                {
                    advancehistory.Transactor = temp;
                    advanceEntry.AdvanceHistories.Add(advancehistory);
                }
                return advance;
            });

            return advances.Values;
        }

        public async Task<IEnumerable<Advance>> GetAdvanceList(int employeeId)
        {
            string query = @"SELECT *
                            from Advance a
                            join Status s on s.ID = a.StatusID
                            join AdvanceHistory ah on ah.AdvanceID = a.ID 
                            join Employee emp on emp.ID = a.EmployeeID
                            join Employee temp on temp.ID = ah.TransactorID
                            left join Payment p on p.AdvanceID = a.ID
                            left join Receipt r on r.AdvanceID = a.ID";

            var advances = new Dictionary<int, Advance>();

            var result = await Connection.QueryAsync<Advance,Status, AdvanceHistory, Employee, Employee, Payment, Receipt, Advance>(query, (advance, status, advancehistory, emp, temp, payment, receipt) =>
            {
                if (!advances.TryGetValue(advance.Id, out Advance advanceEntry))
                {
                    advance.Employee = emp;
                    advance.Status = status;
                    advanceEntry = advance;
                    advanceEntry.Project = new Project();
                    advanceEntry.Payments = new List<Payment>();
                    advanceEntry.Receipts = new List<Receipt>();
                    advanceEntry.AdvanceHistories = new List<AdvanceHistory>();
                    advances.Add(advance.Id, advanceEntry);
                }

                if (payment != null && !advanceEntry.Payments.Any(x => x.Id == payment.Id))
                    advanceEntry.Payments.Add(payment);

                if (receipt != null && !advanceEntry.Receipts.Any(x => x.Id == receipt.Id))
                    advanceEntry.Receipts.Add(receipt);

                if (advancehistory != null
                && !advanceEntry.AdvanceHistories.Any(x => x.Id == advancehistory.Id)
                && ((payment == null) || (advancehistory.TransactorId != payment.FinanceManagerId))
                && ((receipt == null) || (advancehistory.TransactorId != receipt.AccountantId)))
                {
                    advancehistory.Transactor = temp;
                    advanceEntry.AdvanceHistories.Add(advancehistory);
                }
                return advance;
            });

            return advances.Values;
        }
    }
}
