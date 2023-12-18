﻿using AdvanceAPI.Entities.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdvanceAPI.DAL.Repositories.Abstract
{
	public interface IBusinessUnitDAL
	{
		Task<IEnumerable<BusinessUnit>> GetAllBusinessUnits();
		Task<BusinessUnit> GetBusinessUnitById(int Id);

    }
}
