using AdvanceAPI.DAL.Repositories.Abstract;
using AdvanceAPI.Entities.Entity;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAPI.DAL.Repositories.Concrete
{
    public class PageDAL : BaseDAL, IPageDAL
    {
        public PageDAL(IDbConnection connection, IDbTransaction transaction) : base(connection, transaction)
        {
        }

        public async Task<IEnumerable<Page>> GetPagesWithSelectAuthorization(int titleId)
        {
            string query = @"SELECT p.*
                             FROM Page p
                             JOIN TitleAuthorization ta ON p.PageID = ta.PageID
                             WHERE ta.TitleID = @TitleId AND ta.AuthorizationID = 1";

            var pages = await Connection.QueryAsync<Page>(query, new { TitleId = titleId }, Transaction);

            return pages;
        }
    }
}

