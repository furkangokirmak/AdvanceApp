using AdvanceAPI.DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAPI.DAL.UnitOfWork
{
    public interface IUnitOfWork
    {
		IAdvanceHistoryDAL AdvanceHistoryDAL { get; }
		IAdvanceDAL AdvanceDAL { get; }
		IAuthDAL AuthDAL { get; }
		IAuthorizationDAL AuthorizationDAL { get; }
		IBusinessUnitDAL BusinessUnitDAL { get; }
		IEmployeeDAL EmployeeDAL { get; }
		IEmployeeProjectDAL EmployeeProjectDAL { get; }
		IPageDAL PageDAL { get; }
		IPaymentDAL PaymentDAL { get; }
		IProjectDAL ProjectDAL { get; }
		IReceiptDAL ReceiptDAL { get; }
		IRuleDAL RuleDAL { get; }
		IStatusDAL StatusDAL { get; }
		ITitleAuthorizationDAL TitleAuthorizationDAL { get; }
		ITitleDAL TitleDAL { get; }

		void Commit();
        void BeginTransaction();
    }
}
