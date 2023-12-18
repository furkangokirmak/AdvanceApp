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

        public async Task<Result<string>> AddAdvance(AdvanceInsertDTO advanceInsertDTO)
        {
            var mappedAdvance = _mapper.Map<AdvanceInsertDTO, Advance>(advanceInsertDTO);

            _unitOfWork.BeginTransaction();

            var advance = await _unitOfWork.AdvanceDAL.AddAdvance(mappedAdvance);

            _unitOfWork.Commit();

            if (!advance)
                return Result<string>.Fail("Avans talebi oluşturulamadı!");

            return Result<string>.Success("Avans talebi oluşturuldu.");
        }

        public async Task<Result<IEnumerable<AdvanceSelectDTO>>> GetEmployeeAdvances(int employeeId)
        {
            var advances = await _unitOfWork.AdvanceDAL.GetEmployeeAdvances(employeeId);
            if (advances == null)
                throw new Exception("Geçmiş bulunamadı");

            foreach (var advance in advances)
            {
                var statu = await _unitOfWork.StatusDAL.GetStatusById(advance.StatusId.Value);
                advance.Status = statu;

                var project = await _unitOfWork.ProjectDAL.GetProjectById(advance.ProjectId.Value);
                advance.Project = project;
            }            

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
                UpdateTransactorInfo(latestHistoryFM, "FM", "Kullanıcıları", "FM Tarih Belirleme");

                var latestHistoryAC = advanceHistories.LastOrDefault(x => x.Status.Id == 206);
                UpdateTransactorInfo(latestHistoryAC, "Muhasebe", "Kullanıcıları", "Paranın Ödenmesi");

                var latestHistoryAdvanceEnd = advanceHistories.LastOrDefault(x => x.Status.Id == 207);
                UpdateTransactorInfo(latestHistoryAdvanceEnd, "Muhasebe", "Kullanıcıları", "Avans Kapama");

                var latestHistoryEnd = advanceHistories.LastOrDefault(x => x.Status.Id == 208);
                UpdateTransactorInfo(latestHistoryEnd,"","","");
            }

            if (advanceStatus.Id == 103)
            {
				UpdateTransactorInfo(advanceHistories.LastOrDefault(), "", "", "");
			}

            var mappedAdvanceHistories = _mapper.Map<IEnumerable<AdvanceHistory>, IEnumerable<AdvanceHistorySelectDTO>>(advanceHistories);

            return Result<IEnumerable<AdvanceHistorySelectDTO>>.Success(mappedAdvanceHistories);
        }

        private void UpdateTransactorInfo(AdvanceHistory history, string name, string surname, string titleDescription)
        {
            if (history != null)
			{
				history.Transactor.UpperEmployee.Name = name;
				history.Transactor.UpperEmployee.Surname = surname;
				history.Transactor.UpperEmployee.Title.TitleDescription = titleDescription;
			}
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

        public async Task<Result<string>> AdvanceRequestAccept(AdvanceHistorySelectDTO adHistory)
        {
            _unitOfWork.BeginTransaction();

            // isDone durumunu last historydekini true ya çeker
            var lastAdvanceHistory = await _unitOfWork.AdvanceHistoryDAL.GetAdvanceLastHistory(adHistory.AdvanceId.Value);
            await _unitOfWork.AdvanceHistoryDAL.UpdateAdvanceHistoryDone(lastAdvanceHistory.Id, true);

            var rule = await _unitOfWork.RuleDAL.GetRuleByEmployeeId(adHistory.TransactorId.Value);
            adHistory.StatusId += 1;
            var mappedAdHistory = _mapper.Map<AdvanceHistorySelectDTO, AdvanceHistory>(adHistory);

            var history = await _unitOfWork.AdvanceHistoryDAL.AddAdvanceHistory(mappedAdHistory);

            if (!history)
                return Result<string>.Fail("Avans onaylanırken bir sorun oluştu!");

            if (adHistory.ApprovedAmount <= rule.MaxAmount)
            {
                // yeterli ise direk advanceyi onayla statüsüne getir
                var state = await _unitOfWork.AdvanceDAL.UpdateAdvanceStatus(adHistory.AdvanceId.Value, 102);

                if (!state)
                    return Result<string>.Fail("Avans onaylanırken bir sorun oluştu!");
            }

            _unitOfWork.Commit();

            return Result<string>.Success("Avans onaylandı.");
        }

        public async Task<Result<string>> AdvanceRequestReject(AdvanceHistorySelectDTO adHistory)
        {
            var mappedAdHistory = _mapper.Map<AdvanceHistorySelectDTO, AdvanceHistory>(adHistory);
            mappedAdHistory.StatusId = 103;

			_unitOfWork.BeginTransaction();

            var advance = await _unitOfWork.AdvanceHistoryDAL.AddAdvanceHistory(mappedAdHistory);

            var status = await _unitOfWork.AdvanceDAL.UpdateAdvanceStatus(adHistory.AdvanceId.Value, 103);

            _unitOfWork.Commit();

            if (!advance || !status)
                return Result<string>.Fail("Avans reddedilirken bir sorun oluştu!");

            return Result<string>.Success("Avans reddedildi.");
        }

        public async Task<Result<string>> AdvanceRequestSetPaymentDate(AdvanceHistorySelectDTO adHistory)
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
                return Result<string>.Fail("Avans tarihi belirlenirken bir sorun oluştu!");

            return Result<string>.Success("Avans tarihi belirlendi.");
        }

        public async Task<Result<string>> AdvanceRequestReceipt(AdvanceSelectDTO dto)
        {
            var mappedAdHistory = _mapper.Map<AdvanceHistorySelectDTO, AdvanceHistory>(dto.AdvanceHistories.FirstOrDefault());
            var mappedReceipt = _mapper.Map<ReceiptSelectDTO, Receipt>(dto.Receipts.FirstOrDefault());

            _unitOfWork.BeginTransaction();

            var resultAdvanceHistory = await _unitOfWork.AdvanceHistoryDAL.AddAdvanceHistory(mappedAdHistory);

            var resultReceipt = await _unitOfWork.ReceiptDAL.AddReceipt(mappedReceipt);

            _unitOfWork.Commit();

            if (!resultAdvanceHistory || !resultReceipt)
                throw new Exception("Makbuz eklenirken bir sorun oluştu!");

            return Result<string>.Success("Makbuz eklendi.");
        }
    }
}
