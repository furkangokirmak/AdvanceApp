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
    public class StatusDAL : BaseDAL, IStatusDAL
    {
        public StatusDAL(IDbConnection connection, IDbTransaction transaction) : base(connection, transaction)
        {
        }

        public async Task<Status> GetStatusById(int Id)
        {
            var query = "SELECT * FROM Status WHERE Id = @Id";
            var result = await Connection.QueryAsync<Status>(query, new { Id });

            return result.FirstOrDefault();
        }
    }
}
