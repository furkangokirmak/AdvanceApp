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
	public class ProjectDAL : BaseDAL, IProjectDAL
	{
		public ProjectDAL(IDbConnection connection, IDbTransaction transaction) : base(connection, transaction)
		{
		}

        public async Task<Project> GetProjectById(int Id)
        {
            var query = "SELECT * FROM Project WHERE Id = @Id";
            var result = await Connection.QueryAsync<Project>(query, new { Id });

            return result.FirstOrDefault();
        }

        public async Task<IEnumerable<Project>> GetAllProjects()
        {
            var query = "SELECT * FROM Project";
            var result = await Connection.QueryAsync<Project>(query);

            return result;
        }
    }
}
