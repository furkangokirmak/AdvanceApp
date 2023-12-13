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
	public class EmployeeDAL : BaseDAL, IEmployeeDAL
	{
		public EmployeeDAL(IDbConnection connection, IDbTransaction transaction) : base(connection, transaction)
		{

		}

		public async Task<IEnumerable<Employee>> GetAllEmployees()
		{
			var query = "SELECT * FROM Employee";
			var result = await Connection.QueryAsync<Employee>(query);

			return result;
		}
	}
}
