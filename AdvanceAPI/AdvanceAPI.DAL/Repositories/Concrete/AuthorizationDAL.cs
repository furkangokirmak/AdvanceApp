using AdvanceAPI.DAL.Repositories.Abstract;
using System.Data;

namespace AdvanceAPI.DAL.Repositories.Concrete
{
	public class AuthorizationDAL : BaseDAL, IAuthorizationDAL
	{
		public AuthorizationDAL(IDbConnection connection, IDbTransaction transaction) : base(connection, transaction)
		{
		}
	}
}
