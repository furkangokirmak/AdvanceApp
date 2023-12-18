using AdvanceAPI.DAL.Repositories.Abstract;
using AdvanceAPI.Entities.Entity;
using Dapper;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAPI.DAL.Repositories.Concrete
{
    public class AuthDAL : BaseDAL, IAuthDAL
    {
        public AuthDAL(IDbConnection connection, IDbTransaction transaction) : base(connection, transaction)
        {
        }

        public async Task<Employee> Login(string email)
        {
            string query = @"SELECT e.ID,e.Email,e.PasswordHash,e.PasswordSalt,e.TitleID,e.BusinessUnitID,e.Name,e.Surname,e.PhoneNumber,
                            t.ID,t.TitleName,
                            bu.ID,bu.BusinessUnitName
                            FROM Employee e
                            JOIN Title t on t.ID = e.TitleID
                            JOIN BusinessUnit bu on bu.ID = e.BusinessUnitID
                            WHERE Email=@Email";

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Email", email, DbType.String);

            var user = await Connection.QueryAsync<Employee, Title,BusinessUnit, Employee>(query, (employee, title, businessunit) => 
            {
                employee.Title = title;
                employee.BusinessUnit = businessunit;
                return employee;
            }, parameters, Transaction);

            return user.FirstOrDefault();
        }

        public async Task<bool> Register(Employee employee)
        {            
            string queryRegister = @"INSERT INTO Employee (Name,Surname,PhoneNumber,Email,PasswordHash,PasswordSalt,BusinessUnitID,TitleID,UpperEmployeeID) VALUES (@Name, @Surname,@PhoneNumber,@Email,@PasswordHash,@PasswordSalt,@BusinessUnitID,@TitleID,@UpperEmployeeID)";

            var parameters = new DynamicParameters();
            parameters.Add("@Name", employee.Name, DbType.String);
            parameters.Add("@Surname", employee.Surname, DbType.String);
            parameters.Add("@PhoneNumber", employee.PhoneNumber, DbType.String);
            parameters.Add("@EMail", employee.Email, DbType.String);
            parameters.Add("@PasswordHash", employee.PasswordHash, DbType.Binary);
            parameters.Add("@PasswordSalt", employee.PasswordSalt, DbType.Binary);
            parameters.Add("@BusinessUnitID", employee.BusinessUnitId, DbType.Int32);
            parameters.Add("@TitleID", employee.TitleId, DbType.Int32);
            parameters.Add("@UpperEmployeeID", employee.UpperEmployeeId, DbType.Int32);

            var rowsAffected = await Connection.ExecuteAsync(queryRegister, parameters, Transaction);

            return rowsAffected > 0;
        }

		public async Task<Employee> GetEmployeeByEmail(string email)
		{
			string query = @"SELECT * FROM Employee
                            WHERE Email=@Email";

			DynamicParameters parameters = new DynamicParameters();
			parameters.Add("@Email", email, DbType.String);

			var user = await Connection.QueryAsync<Employee>(query, parameters, Transaction);

			return user.FirstOrDefault();
		}

        public async Task<bool> SetPassword(Employee employee)
        {
            string query = @"UPDATE Employee 
                            SET PasswordHash=@PasswordHash, PasswordSalt=@PasswordSalt
                            WHERE Email=@Email";

            var rowsAffected = await Connection.ExecuteAsync(query, new {employee.PasswordHash, employee.PasswordSalt, employee.Email }, Transaction);

            return rowsAffected > 0;
        }
    }
}
