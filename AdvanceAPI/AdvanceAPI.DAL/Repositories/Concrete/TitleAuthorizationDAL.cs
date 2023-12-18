using AdvanceAPI.DAL.Repositories.Abstract;
using System.Data;

namespace AdvanceAPI.DAL.Repositories.Concrete
{
    public class TitleAuthorizationDAL : BaseDAL, ITitleAuthorizationDAL
	{
		public TitleAuthorizationDAL(IDbConnection connection, IDbTransaction transaction) : base(connection, transaction)
		{
		}
	}
}
