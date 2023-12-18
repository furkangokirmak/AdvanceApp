using AdvanceAPI.BLL.Abstract;
using AdvanceAPI.BLL.Mapper;
using AdvanceAPI.DAL.UnitOfWork;

namespace AdvanceAPI.BLL.Concrete
{
	public class PaymentManager : IPaymentManager
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly MyMapper _mapper;

		public PaymentManager(IUnitOfWork unitOfWork, MyMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}
	}
}
