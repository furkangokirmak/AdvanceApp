using AdvanceAPI.BLL.Abstract;
using AdvanceAPI.BLL.Mapper;
using AdvanceAPI.CORE.Helper;
using AdvanceAPI.CORE.Utilities;
using AdvanceAPI.DAL.UnitOfWork;
using AdvanceAPI.DTOs.Advance;
using AdvanceAPI.DTOs.AdvanceHistory;
using AdvanceAPI.DTOs.Employee;
using AdvanceAPI.DTOs.Receipt;
using AdvanceAPI.DTOs.Title;
using AdvanceAPI.Entities.Entity;
using AdvanceAPI.ExceptionHandling.Employee;
using Microsoft.AspNetCore.Server.IIS.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAPI.BLL.Concrete
{
    public class AdvanceManager : IAdvanceManager
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly MyMapper _mapper;

        public AdvanceManager(IUnitOfWork unitOfWork, MyMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<AdvanceInsertDTO>> AddAdvance(AdvanceInsertDTO advanceInsertDTO)
        {
            var mappedAdvance = _mapper.Map<AdvanceInsertDTO, Advance>(advanceInsertDTO);

            _unitOfWork.BeginTransaction();

            var advance = await _unitOfWork.AdvanceDAL.AddAdvance(mappedAdvance);

            _unitOfWork.Commit();

            return Result<AdvanceInsertDTO>.Success(advanceInsertDTO);
        }

        public async Task<Result<IEnumerable<AdvanceSelectDTO>>> GetEmployeeAdvances(int employeeId)
        {
            var advances = await _unitOfWork.AdvanceDAL.GetEmployeeAdvances(employeeId);
            if (advances == null)
                throw new Exception("Geçmiş bulunamadı");

            var mappedAdvances = _mapper.Map<IEnumerable<Advance>, IEnumerable<AdvanceSelectDTO>>(advances);

            return Result<IEnumerable<AdvanceSelectDTO>>.Success(mappedAdvances);
        }

        public async Task<Result<AdvanceSelectDTO>> GetAdvanceById(int advanceId)
        {
            var advance = await _unitOfWork.AdvanceDAL.GetAdvanceById(advanceId);
            if (advance == null)
                throw new Exception("Avans bulunamadı");

            var mappedAdvance = _mapper.Map<Advance, AdvanceSelectDTO>(advance);

            return Result<AdvanceSelectDTO>.Success(mappedAdvance);
        }


        public async Task<Result<IEnumerable<AdvanceHistorySelectDTO>>> GetAdvanceHistory(int advanceId)
        {
            var advanceHistories = await _unitOfWork.AdvanceDAL.GetAdvanceHistory(advanceId);

            var advanceStatus = await _unitOfWork.StatusDAL.GetStatusByAdvanceId(advanceId);

            var latestHistoryFM = advanceHistories
            .Where(x => x.Status.Id > 200 && x.Status.Id < 206)
            .LastOrDefault();

            if (advanceStatus.Id == 102 && latestHistoryFM != null)
            {
                latestHistoryFM.Transactor.UpperEmployee.Name = "FM";
                latestHistoryFM.Transactor.UpperEmployee.Surname = "Kullanıcıları";
                latestHistoryFM.Transactor.UpperEmployee.Title.TitleDescription = "FM Tarih Belirleme";
            }

            var latestHistoryAC = advanceHistories
            .Where(x => x.Status.Id == 206)
            .LastOrDefault();

            if (advanceStatus.Id == 102 && latestHistoryAC != null)
            {
                latestHistoryAC.Transactor.UpperEmployee.Name = "Muhasebe";
                latestHistoryAC.Transactor.UpperEmployee.Surname = "Kullanıcıları";
                latestHistoryAC.Transactor.UpperEmployee.Title.TitleDescription = "Paranın Ödenmesi";
            }

            var mappedAdvanceHistories = _mapper.Map<IEnumerable<AdvanceHistory>, IEnumerable<AdvanceHistorySelectDTO>>(advanceHistories);

            return Result<IEnumerable<AdvanceHistorySelectDTO>>.Success(mappedAdvanceHistories);
        }
        
        public async Task<Result<IEnumerable<AdvanceSelectDTO>>> GetPendingAdvance(int employeeId)
        {
            var pendingAdvances = await _unitOfWork.AdvanceDAL.GetPendingAdvance(employeeId);

            foreach (var item in pendingAdvances)
            {
                var titleEmp = await _unitOfWork.TitleDAL.GetTitleById(item.Employee.TitleId.Value);
                item.Employee.Title = titleEmp;

                var titleTransactor = await _unitOfWork.TitleDAL.GetTitleById(item.AdvanceHistories.LastOrDefault().Transactor.TitleId.Value);
                item.AdvanceHistories.LastOrDefault().Transactor.Title = titleTransactor;

                var project = await _unitOfWork.ProjectDAL.GetProjectById(item.ProjectId.Value);    
                item.Project = project;

                var businessUnitEmp = await _unitOfWork.BusinessUnitDAL.GetBusinessUnitById(item.Employee.BusinessUnitId.Value);
                item.Employee.BusinessUnit = businessUnitEmp;
            }

            var mappedPendingAdvances = _mapper.Map<IEnumerable<Advance>, IEnumerable<AdvanceSelectDTO>>(pendingAdvances);

            return Result<IEnumerable<AdvanceSelectDTO>>.Success(mappedPendingAdvances);
        }

        public async Task<Result<IEnumerable<AdvanceSelectDTO>>> GetPendingPaymentDateAdvance()
        {
            var pendingAdvances = await _unitOfWork.AdvanceDAL.GetPendingPaymentDateAdvance();

            foreach (var item in pendingAdvances)
            {
                var titleEmp = await _unitOfWork.TitleDAL.GetTitleById(item.Employee.TitleId.Value);
                item.Employee.Title = titleEmp;

                var titleTransactor = await _unitOfWork.TitleDAL.GetTitleById(item.AdvanceHistories.LastOrDefault().Transactor.TitleId.Value);
                item.AdvanceHistories.LastOrDefault().Transactor.Title = titleTransactor;

                var project = await _unitOfWork.ProjectDAL.GetProjectById(item.ProjectId.Value);
                item.Project = project;

                var businessUnitEmp = await _unitOfWork.BusinessUnitDAL.GetBusinessUnitById(item.Employee.BusinessUnitId.Value);
                item.Employee.BusinessUnit = businessUnitEmp;
            }

            var mappedPendingAdvances = _mapper.Map<IEnumerable<Advance>, IEnumerable<AdvanceSelectDTO>>(pendingAdvances);

            return Result<IEnumerable<AdvanceSelectDTO>>.Success(mappedPendingAdvances);
        }

        public async Task<Result<IEnumerable<AdvanceSelectDTO>>> GetPendingReceipt()
        {
            var pendingAdvances = await _unitOfWork.AdvanceDAL.GetPendingReceipt();

            var mappedPendingAdvances = _mapper.Map<IEnumerable<Advance>, IEnumerable<AdvanceSelectDTO>>(pendingAdvances);

            return Result<IEnumerable<AdvanceSelectDTO>>.Success(mappedPendingAdvances);
        }

        public async Task<Result<AdvanceHistorySelectDTO>> AdvanceRequestAccept(AdvanceHistorySelectDTO adHistory)
        {
            var rule = await _unitOfWork.RuleDAL.GetRuleByEmployeeId(adHistory.TransactorId.Value);

            // kişinin statusunude cekip

            adHistory.StatusId += 1;

            var mappedAdHistory = _mapper.Map<AdvanceHistorySelectDTO, AdvanceHistory>(adHistory);

            _unitOfWork.BeginTransaction();

            // sadece veritabanına historyi ekle
            var history = await _unitOfWork.AdvanceHistoryDAL.AddAdvanceHistory(mappedAdHistory);

            if (adHistory.ApprovedAmount <= rule.MaxAmount)
            {
                // yeterli ise direk advanceyi onayla statüsüne getir
                var state = await _unitOfWork.AdvanceDAL.UpdateAdvanceStatus(adHistory.AdvanceId.Value, 102);
            }


            _unitOfWork.Commit();

            return Result<AdvanceHistorySelectDTO>.Success(adHistory);
        }

        public async Task<Result<AdvanceHistorySelectDTO>> AdvanceRequestReject(AdvanceHistorySelectDTO adHistory)
        {
            var mappedAdHistory = _mapper.Map<AdvanceHistorySelectDTO, AdvanceHistory>(adHistory);

            _unitOfWork.BeginTransaction();

            await _unitOfWork.AdvanceHistoryDAL.AddAdvanceHistory(mappedAdHistory);

            await _unitOfWork.AdvanceDAL.UpdateAdvanceStatus(adHistory.AdvanceId.Value, 103);
            
            _unitOfWork.Commit();

            return Result<AdvanceHistorySelectDTO>.Success(adHistory);
        }

        public async Task<Result<bool>> AdvanceRequestSetPaymentDate(AdvanceHistorySelectDTO adHistory)
        {
			var mappedAdHistory = _mapper.Map<AdvanceHistorySelectDTO, AdvanceHistory>(adHistory);
			var paymentDate = mappedAdHistory.Date;
            mappedAdHistory.Date = DateTime.Now;
            mappedAdHistory.StatusId = 206;

			var payment = new Payment
			{
				AdvanceId = mappedAdHistory.AdvanceId,
				DeterminedPaymentDate = paymentDate,
				FinanceManagerId = mappedAdHistory.TransactorId
			};

			_unitOfWork.BeginTransaction();

            var resultAdvanceHistory = await _unitOfWork.AdvanceHistoryDAL.AddAdvanceHistory(mappedAdHistory);

            var resultPayment = await _unitOfWork.PaymentDAL.AddPayment(payment);

            _unitOfWork.Commit();

			if (!resultAdvanceHistory || !resultPayment)
				return Result<bool>.Fail("Hata oluştu");

			return Result<bool>.Success(true);
		}

        public async Task<Result<AdvanceSelectDTO>> AdvanceRequestReceipt(AdvanceSelectDTO dto)
        {
            var mappedAdHistory = _mapper.Map<AdvanceHistorySelectDTO, AdvanceHistory>(dto.AdvanceHistories.FirstOrDefault());  
            var mappedReceipt = _mapper.Map<ReceiptSelectDTO, Receipt>(dto.Receipts.FirstOrDefault());

            _unitOfWork.BeginTransaction();

            var resultAdvanceHistory = await _unitOfWork.AdvanceHistoryDAL.AddAdvanceHistory(mappedAdHistory);

            var resultReceipt = await _unitOfWork.ReceiptDAL.AddReceipt(mappedReceipt);

            _unitOfWork.Commit();

            if (!resultAdvanceHistory || !resultReceipt)
                throw new Exception("Bir hata oluştu!");

            return Result<AdvanceSelectDTO>.Success(dto);
        }
    }
}
