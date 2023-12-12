using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
