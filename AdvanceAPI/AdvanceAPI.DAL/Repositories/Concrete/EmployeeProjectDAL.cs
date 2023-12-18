using AdvanceAPI.DAL.Repositories.Abstract;
using System.Data;

namespace AdvanceAPI.DAL.Repositories.Concrete
{
	public class EmployeeProjectDAL : BaseDAL, IEmployeeProjectDAL
	{
		public EmployeeProjectDAL(IDbConnection connection, IDbTransaction transaction) : base(connection, transaction)
		{
		}
	}
}
