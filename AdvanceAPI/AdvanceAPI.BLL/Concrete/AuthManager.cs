using AdvanceAPI.BLL.Abstract;
using AdvanceAPI.BLL.Mapper;
using AdvanceAPI.CORE.Helper;
using AdvanceAPI.CORE.Utilities;
using AdvanceAPI.DAL.Repositories.Abstract;
using AdvanceAPI.DAL.Repositories.Concrete;
using AdvanceAPI.DAL.UnitOfWork;
using AdvanceAPI.DTOs.Employee;
using AdvanceAPI.Entities.Entity;
using AdvanceAPI.ExceptionHandling.Base;
using AdvanceAPI.ExceptionHandling.Employee;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAPI.BLL.Concrete
{
    public class AuthManager : IAuthManager
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly MyMapper _mapper;
        private readonly TokenHelper _tokenHelper;
        public AuthManager(IUnitOfWork unitOfWork, TokenHelper tokenHelper, MyMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _tokenHelper = tokenHelper;
            _mapper = mapper;
        }

        public async Task<Result<EmployeeSelectDTO>> Login(EmployeeLoginDTO employeeLoginDTO)
        {
            var employee = await _unitOfWork.AuthDAL.Login(employeeLoginDTO.Email);

            if (employee == null)
                throw new EmployeeNotFoundException("User not found");

            if (!HashingHelper.CheckPassword(employeeLoginDTO.Password, employee.PasswordSalt, employee.PasswordHash))
                throw new PasswordsNotMatchException("Passwords did not match");

            var employeeDTO = _mapper.Map<Employee, EmployeeSelectDTO>(employee);

            employeeDTO.Token = _tokenHelper.CreateToken(employee);

            return Result<EmployeeSelectDTO>.Success(employeeDTO);          
        }

        public async Task<Result<bool>> Register(EmployeeRegisterDTO employeeRegisterDTO)
        {
            if (employeeRegisterDTO.Password != employeeRegisterDTO.PasswordConfirm)
                throw new PasswordsNotMatchException("Passwords did not match");

            var employeeCheck = await _unitOfWork.AuthDAL.Login(employeeRegisterDTO.Email);
            if (employeeCheck != null)
                throw new DuplicateEmployeeException("This user is already registered");

            byte[] passHash, passSalt;
            HashingHelper.CreatePassword(employeeRegisterDTO.Password, out passHash, out passSalt);

            var employee = _mapper.Map<EmployeeRegisterDTO, Employee>(employeeRegisterDTO);
            employee.PasswordHash = passHash;
            employee.PasswordSalt = passSalt;

            var state = await _unitOfWork.AuthDAL.Register(employee);

            return Result<bool>.Success(true);
        }
    }
}
