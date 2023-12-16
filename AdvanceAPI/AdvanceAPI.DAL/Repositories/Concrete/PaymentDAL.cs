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
	public class PaymentDAL : BaseDAL, IPaymentDAL
	{
		public PaymentDAL(IDbConnection connection, IDbTransaction transaction) : base(connection, transaction)
		{
		}

		public async Task<bool> AddPayment(Payment payment)
		{
			string query = @"INSERT INTO Payment (DeterminedPaymentDate, FinanceManagerID, AdvanceID) values (@DeterminedPaymentDate, @FinanceManagerId, @AdvanceId)";

			var parameters = new { payment.DeterminedPaymentDate, payment.FinanceManagerId, payment.AdvanceId };

			var rowsAffected = await Connection.ExecuteAsync(query, parameters, Transaction);

			return rowsAffected > 0;
		}
	}
}
