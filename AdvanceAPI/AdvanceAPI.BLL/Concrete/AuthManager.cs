using AdvanceAPI.BLL.Abstract;
using AdvanceAPI.BLL.Mapper;
using AdvanceAPI.CORE.Helper;
using AdvanceAPI.DAL.Repositories.Abstract;
using AdvanceAPI.DAL.Repositories.Concrete;
using AdvanceAPI.DAL.UnitOfWork;
using AdvanceAPI.DTOs.Employee;
using AdvanceAPI.Entities.Entity;
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

        public async Task<string> Login(EmployeeLoginDTO employeeLoginDTO)
        {
            var employee = await _unitOfWork.AuthDAL.Login(employeeLoginDTO.Email);

            if (employee != null && HashingHelper.CheckPassword(employeeLoginDTO.Password, employee.PasswordSalt, employee.PasswordHash))
                return _tokenHelper.CreateToken(employee);

            return null;
        }

        public async Task<bool> Register(EmployeeRegisterDTO employeeRegisterDTO)
        {
            if (employeeRegisterDTO.Password != employeeRegisterDTO.PasswordConfirm)
                return false;

            byte[] passHash, passSalt;
            HashingHelper.CreatePassword(employeeRegisterDTO.Password, out passHash, out passSalt);

            var employee = _mapper.Map<EmployeeRegisterDTO, Employee>(employeeRegisterDTO);
            employee.PasswordHash = passHash;
            employee.PasswordSalt = passSalt;

            var state = await _unitOfWork.AuthDAL.Register(employee);

            return state;
        }
    }
}
