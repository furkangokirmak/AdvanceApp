﻿using AdvanceAPI.BLL.Abstract;
using AdvanceAPI.BLL.Mapper;
using AdvanceAPI.CORE.Utilities;
using AdvanceAPI.DAL.UnitOfWork;
using AdvanceAPI.DTOs.Employee;
using AdvanceAPI.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdvanceAPI.BLL.Concrete
{
	public class EmployeeManager : IEmployeeManager
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly MyMapper _mapper;

		public EmployeeManager(IUnitOfWork unitOfWork, MyMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}

		public async Task<Result<IEnumerable<EmployeeSelectDTO>>> GetAllEmployees()
		{
			var employees = await _unitOfWork.EmployeeDAL.GetAllEmployees();

			var employeesMapped = _mapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeSelectDTO>>(employees);

			return Result<IEnumerable<EmployeeSelectDTO>>.Success(employeesMapped);
		}

		public async Task<Result<EmployeeSelectDTO>> GetEmployeeByEmail(string email)
		{
			var employee = await _unitOfWork.AuthDAL.GetEmployeeByEmail(email);
			if (employee == null)
			{
				throw new Exception("Böyle bir kullanıcı yok!");
			}

			var employeesMapped = _mapper.Map<Employee, EmployeeSelectDTO>(employee);

			return Result<EmployeeSelectDTO>.Success(employeesMapped);
		}
	}
}
