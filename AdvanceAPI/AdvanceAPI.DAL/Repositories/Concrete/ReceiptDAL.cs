﻿using AdvanceAPI.DAL.Repositories.Abstract;
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
	public class ReceiptDAL : BaseDAL, IReceiptDAL
	{
		public ReceiptDAL(IDbConnection connection, IDbTransaction transaction) : base(connection, transaction)
		{
		}

		public async Task<bool> AddReceipt(Receipt receipt) 
		{
			string query = @"INSERT INTO Receipt (ReceiptNo, isRefundReceipt, AdvanceID, Date, AccountantID) values (@DeterminedPaymentDate, @FinanceManagerId, @AdvanceId, @Date, @AccountantId)";

			var parameters = new { receipt.ReceiptNo, receipt.IsRefundReceipt, receipt.AdvanceId, receipt.Date, receipt.AccountantId};

			var rowsAffected = await Connection.ExecuteAsync(query, parameters, Transaction);

			return rowsAffected > 0;
		}
	}
}
