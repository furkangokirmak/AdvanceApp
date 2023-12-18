using AdvanceAPI.Entities.Entity;
using System.Threading.Tasks;

namespace AdvanceAPI.DAL.Repositories.Abstract
{
	public interface IReceiptDAL
	{
		Task<bool> AddReceipt(Receipt receipt);
	}
}
