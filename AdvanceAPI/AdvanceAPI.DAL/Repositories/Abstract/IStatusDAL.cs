using AdvanceAPI.Entities.Entity;
using System.Threading.Tasks;

namespace AdvanceAPI.DAL.Repositories.Abstract
{
	public interface IStatusDAL
	{
        Task<Status> GetStatusById(int Id);

        Task<Status> GetStatusByAdvanceId(int Id);
    }
}
