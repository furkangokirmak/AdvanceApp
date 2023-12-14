﻿using AdvanceAPI.DAL.Repositories.Abstract;
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
	}
}