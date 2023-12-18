using AdvanceAPI.Entities.Entity;
using System.Threading.Tasks;

namespace AdvanceAPI.DAL.Repositories.Abstract
{
	public interface IPaymentDAL
	{
		Task<bool> AddPayment(Payment payment);
	}
}
