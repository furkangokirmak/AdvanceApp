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
    public class AuthDAL : BaseDAL, IAuthDAL
    {
        public AuthDAL(IDbConnection connection, IDbTransaction transaction) : base(connection, transaction)
        {
        }

        public async Task<Employee> Login(string email)
        {
            string query = @"SELECT Email,PasswordHash,PasswordSalt FROM Employee
                             WHERE Email=@Email";

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Email", email, DbType.String);

            var user = await Connection.QueryFirstOrDefaultAsync<Employee>(query, parameters);

            return user;
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

            var rowsAffected = await Connection.ExecuteAsync(queryRegister, parameters);

            return rowsAffected > 0;
        }

    }
}
