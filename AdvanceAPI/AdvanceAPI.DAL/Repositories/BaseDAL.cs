using System.Data;

namespace AdvanceAPI.DAL.Repositories
{
    public class BaseDAL
    {
        protected IDbTransaction Transaction { get; private set; }
        protected IDbConnection Connection { get; private set; }

        public BaseDAL(IDbConnection connection, IDbTransaction transaction)
        {
            Connection = connection;
            Transaction = transaction;
        }
    }
}
