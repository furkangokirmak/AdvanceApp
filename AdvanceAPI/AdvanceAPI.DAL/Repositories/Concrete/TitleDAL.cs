﻿using AdvanceAPI.DAL.Repositories.Abstract;
using AdvanceAPI.Entities.Entity;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace AdvanceAPI.DAL.Repositories.Concrete
{
    public class TitleDAL : BaseDAL, ITitleDAL
	{
		public TitleDAL(IDbConnection connection, IDbTransaction transaction) : base(connection, transaction)
		{
		}

		public async Task<Title> GetTitleById(int Id)
		{
			var query = @"SELECT * FROM Title Where Id=@Id";

            var result = await Connection.QueryAsync<Title>(query, new { Id }, Transaction);

            return result.FirstOrDefault();
        }

		public async Task<IEnumerable<Title>> GetAllTitles()
		{
			var query = "SELECT * FROM Title";
			var result = await Connection.QueryAsync<Title>(query, transaction: Transaction);

			return result;
		}
	}
}
