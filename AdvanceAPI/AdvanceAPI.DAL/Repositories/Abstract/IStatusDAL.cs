using AdvanceAPI.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAPI.DAL.Repositories.Abstract
{
	public interface IStatusDAL
	{
        Task<Status> GetStatusById(int Id);

        Task<Status> GetStatusByAdvanceId(int Id);
    }
}
