﻿using AdvanceAPI.DAL.Repositories.Abstract;
using AdvanceAPI.Entities.Entity;
using Dapper;
using System.Data;
using System.Linq;
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
            var result = await Connection.QueryAsync<Status>(query, new { Id }, Transaction);

            return result.FirstOrDefault();
        }

        public async Task<Status> GetStatusByAdvanceId(int Id)
        {
            var query = @"SELECT s.Id,s.StatusName FROM Status s
                        JOIN Advance a on a.StatusId = s.Id
                        WHERE a.Id = @Id";

            var result = await Connection.QueryAsync<Status>(query, new { Id }, Transaction);

            return result.FirstOrDefault();
        }
    }
}
