using AdvanceAPI.DAL.Repositories.Abstract;
using AdvanceAPI.Entities.Entity;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
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
            var result = await Connection.QueryAsync<Project>(query, new { Id }, Transaction);

            return result.FirstOrDefault();
        }

        public async Task<IEnumerable<Project>> GetProjectsByEmployeeID(int id)
        {
            string query = @"SELECT * from EmployeeProject 
                            INNER JOIN Project on EmployeeProject.ProjectID=Project.ID
                            WHERE EmployeeProject.EmployeeID=@EmployeeID";

            var result = await Connection.QueryAsync<Project>(query, new { EmployeeID = id }, Transaction);

            return result.ToList();
        }

        public async Task<IEnumerable<Project>> GetAllProjects()
        {
            var query = "SELECT * FROM Project";
            var result = await Connection.QueryAsync<Project>(query, transaction: Transaction);

            return result;
        }
    }
}
