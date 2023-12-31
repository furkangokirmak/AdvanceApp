﻿using AdvanceAPI.DAL.Repositories.Abstract;
using Dapper;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace AdvanceAPI.DAL.Repositories.Concrete
{
	public class RuleDAL : BaseDAL, IRuleDAL
	{
		public RuleDAL(IDbConnection connection, IDbTransaction transaction) : base(connection, transaction)
		{
		}

		public async Task<Entities.Entity.Rule> GetRuleByTitleId(int TitleId)
		{
			string query = @"Select * from [Rule] r
							JOIN Title t on t.ID = r.TitleID
							WHERE t.Id = @TitleId
							ORDER BY r.Date DESC";

			var result = await Connection.QueryAsync<Entities.Entity.Rule>(query, new { TitleId }, Transaction);

			return result.FirstOrDefault();
		}

        public async Task<Entities.Entity.Rule> GetRuleByEmployeeId(int empId)
        {
            string query = @"Select * from [Rule] r
							JOIN Title t on t.ID = r.TitleID
							JOIN Employee e on e.TitleID = t.Id
							WHERE e.Id = @empId
							ORDER BY r.Date DESC";

            var result = await Connection.QueryAsync<Entities.Entity.Rule>(query, new { empId }, Transaction);

            return result.FirstOrDefault();
        }
    }
}
