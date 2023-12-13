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

        private IAdvanceHistoryDAL _advanceHistoryDAL;
        private IAdvanceDAL _advanceDAL;
		private IAuthDAL _authDAL;
		private IAuthorizationDAL _authorizationDAL;
		private IBusinessUnitDAL _businessUnitDAL;
		private IEmployeeDAL _employeeDAL;
        private IEmployeeProjectDAL _employeeProjectDAL;
        private IPageDAL _pageDAL;
        private IPaymentDAL _paymentDAL;
        private IProjectDAL _projectDAL;
        private IReceiptDAL _receiptDAL;
        private IRuleDAL _ruleDAL;
        private IStatusDAL _statusDAL;
        private ITitleAuthorizationDAL _titleAuthorizationDAL;
		private ITitleDAL _titleDAL;

		public UnitOfWork()
        {
            _connection = new SqlConnection(ConnectionHelper.GetConnectionString());
            _connection.Open();
        }

		public IAdvanceHistoryDAL AdvanceHistoryDAL
		{
			get { return _advanceHistoryDAL ?? (_advanceHistoryDAL = new AdvanceHistoryDAL(_connection, _transaction)); }
		}

		public IAdvanceDAL AdvanceDAL
		{
			get { return _advanceDAL ?? (_advanceDAL = new AdvanceDAL(_connection, _transaction)); }
		}

		public IAuthDAL AuthDAL
		{
			get { return _authDAL ?? (_authDAL = new AuthDAL(_connection, _transaction)); }
		}

		public IAuthorizationDAL AuthorizationDAL
		{
			get { return _authorizationDAL ?? (_authorizationDAL = new AuthorizationDAL(_connection, _transaction)); }
		}

		public IBusinessUnitDAL BusinessUnitDAL
		{
			get { return _businessUnitDAL ?? (_businessUnitDAL = new BusinessUnitDAL(_connection, _transaction)); }
		}

		public IEmployeeDAL EmployeeDAL
		{
			get { return _employeeDAL ?? (_employeeDAL = new EmployeeDAL(_connection, _transaction)); }
		}

		public IEmployeeProjectDAL EmployeeProjectDAL
		{
			get { return _employeeProjectDAL ?? (_employeeProjectDAL = new EmployeeProjectDAL(_connection, _transaction)); }
		}

		public IPageDAL PageDAL
		{
			get { return _pageDAL ?? (_pageDAL = new PageDAL(_connection, _transaction)); }
		}

		public IPaymentDAL PaymentDAL
		{
			get { return _paymentDAL ?? (_paymentDAL = new PaymentDAL(_connection, _transaction)); }
		}

		public IProjectDAL ProjectDAL
		{
			get { return _projectDAL ?? (_projectDAL = new ProjectDAL(_connection, _transaction)); }
		}

		public IReceiptDAL ReceiptDAL
		{
			get { return _receiptDAL ?? (_receiptDAL = new ReceiptDAL(_connection, _transaction)); }
		}

		public IRuleDAL RuleDAL
		{
			get { return _ruleDAL ?? (_ruleDAL = new RuleDAL(_connection, _transaction)); }
		}

		public IStatusDAL StatusDAL
		{
			get { return _statusDAL ?? (_statusDAL = new StatusDAL(_connection, _transaction)); }
		}

		public ITitleAuthorizationDAL TitleAuthorizationDAL
		{
			get { return _titleAuthorizationDAL ?? (_titleAuthorizationDAL = new TitleAuthorizationDAL(_connection, _transaction)); }
		}

		public ITitleDAL TitleDAL
		{
			get { return _titleDAL ?? (_titleDAL = new TitleDAL(_connection, _transaction)); }
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
