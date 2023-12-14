﻿using AdvanceAPI.BLL.Abstract;
using AdvanceAPI.BLL.Mapper;
using AdvanceAPI.DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAPI.BLL.Concrete
{
	public class ReceiptManager : IReceiptManager
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly MyMapper _mapper;

		public ReceiptManager(IUnitOfWork unitOfWork, MyMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}
	}
}