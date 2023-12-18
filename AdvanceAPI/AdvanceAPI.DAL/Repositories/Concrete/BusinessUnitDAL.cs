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
	public class BusinessUnitDAL : BaseDAL, IBusinessUnitDAL
	{
		public BusinessUnitDAL(IDbConnection connection, IDbTransaction transaction) : base(connection, transaction)
		{
		}

        public async Task<BusinessUnit> GetBusinessUnitById(int Id)
        {
            var query = @"SELECT * FROM BusinessUnit Where Id=@Id";

            var result = await Connection.QueryAsync<BusinessUnit>(query, new { Id }, Transaction);

            return result.FirstOrDefault();
        }

        public async Task<IEnumerable<BusinessUnit>> GetAllBusinessUnits()
		{
			var query = "SELECT * FROM BusinessUnit";
			var result = await Connection.QueryAsync<BusinessUnit>(query, transaction: Transaction);

			return result;
		}
	}
}
