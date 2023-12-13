using AdvanceAPI.CORE.Helper;
using AdvanceAPI.DAL.Repositories.Abstract;
using AdvanceAPI.DAL.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAPI.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private IDbConnection _connection;
        private IDbTransaction _transaction;

        private IAuthDAL _authDAL;
        private IBusinessUnitDAL _businessUnitDAL;

        public UnitOfWork()
        {
            _connection = new SqlConnection(ConnectionHelper.GetConnectionString());
            _connection.Open();
        }

        public IAuthDAL AuthDAL
        {
            get { return _authDAL ?? (_authDAL = new AuthDAL(_connection, _transaction)); }
        }

		public IBusinessUnitDAL BusinessUnitDAL
		{
			get { return _businessUnitDAL ?? (_businessUnitDAL = new BusinessUnitDAL(_connection, _transaction)); }
		}

		public void BeginTransaction()
        {
            try
            {
                _transaction = _connection.BeginTransaction();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void Commit()
        {
            try
            {
                _transaction.Commit();
            }
            catch
            {
                _transaction.Rollback();
            }
            finally
            {
                _transaction.Dispose();
            }
        }
    }
}
