using AdvanceAPI.BLL.Abstract;
using AdvanceAPI.BLL.MailService;
using AdvanceAPI.BLL.Mapper;
using AdvanceAPI.CORE.Helper;
using AdvanceAPI.CORE.Utilities;
using AdvanceAPI.DAL.UnitOfWork;
using AdvanceAPI.DTOs.Employee;
using AdvanceAPI.Entities.Entity;
using System;
using System.Threading.Tasks;

namespace AdvanceAPI.BLL.Concrete
{
    public class AuthManager : IAuthManager
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly MyMapper _mapper;
        private readonly TokenHelper _tokenHelper;
        private readonly MailSender _mailSender;
        public AuthManager(IUnitOfWork unitOfWork, TokenHelper tokenHelper, MyMapper mapper, MailSender mailSender)
        {
            _unitOfWork = unitOfWork;
            _tokenHelper = tokenHelper;
            _mapper = mapper;
			_mailSender = mailSender;
        }

		public async Task<Result<string>> ForgotPassword(EmployeeSelectDTO dto)
		{
			var token = Guid.NewGuid().ToString();
			dto.ResetToken = token;
			dto.ResetTokenExpiration = DateTime.Now.AddHours(1);

			var employee = _mapper.Map<EmployeeSelectDTO, Employee>(dto);

            _unitOfWork.BeginTransaction();

			var result = await _unitOfWork.EmployeeDAL.SetEmployeeResetToken(employee);

            if (result)
            {
				string resetLink = $"https://localhost:44333/Auth/ResetPassword?token={token}";
				string emailBody = $"Sayın {employee.Name},\n\n" +
					$"Şifrenizi sıfırlamak için talepte bulundunuz. Lütfen aşağıdaki bağlantıya tıklayarak şifrenizi sıfırlayın:\n" +
					$"<a href=\"{resetLink}\">Şifre Sıfırla</a>\n\n" +
					$"Eğer şifre sıfırlama talebinde bulunmadıysanız, lütfen bu e-postayı görmezden gelin.\n\n";

				_mailSender.SendEmail(employee.Email, "Şifre Sıfırlama", emailBody);
            }

            _unitOfWork.Commit();

			return Result<string>.Success("Mail gönderildi.");
		}

		public async Task<Result<EmployeeSelectDTO>> GetEmployeeByResetToken(string resetToken)
		{
			var user = await _unitOfWork.EmployeeDAL.GetEmployeeByResetToken(resetToken);

			if (user == null)
				throw new Exception("Geçersiz token!");

			var userDTO = _mapper.Map<Employee, EmployeeSelectDTO>(user);

			return Result<EmployeeSelectDTO>.Success(userDTO);
		}

		public async Task<Result<EmployeeSelectDTO>> Login(EmployeeLoginDTO employeeLoginDTO)
        {
            var employee = await _unitOfWork.AuthDAL.Login(employeeLoginDTO.Email);

            if (employee == null)
                throw new Exception("Kullanıcı adı veya şifre hatalı!");

            if (!HashingHelper.CheckPassword(employeeLoginDTO.Password, employee.PasswordSalt, employee.PasswordHash))
                throw new Exception("Şifreler eşleşmiyor!");

            var employeeDTO = _mapper.Map<Employee, EmployeeSelectDTO>(employee);

            employeeDTO.Token = _tokenHelper.CreateToken(employee);

            return Result<EmployeeSelectDTO>.Success(employeeDTO);          
        }

        public async Task<Result<bool>> Register(EmployeeRegisterDTO employeeRegisterDTO)
        {
            if (employeeRegisterDTO.Password != employeeRegisterDTO.PasswordConfirm)
                throw new Exception("Şifreler eşleşmiyor!");

            var employeeCheck = await _unitOfWork.AuthDAL.Login(employeeRegisterDTO.Email);
            if (employeeCheck != null)
                throw new Exception("Bu kullanıcı daha önceden kayıt olmuş!");

            byte[] passHash, passSalt;
            HashingHelper.CreatePassword(employeeRegisterDTO.Password, out passHash, out passSalt);

            var employee = _mapper.Map<EmployeeRegisterDTO, Employee>(employeeRegisterDTO);
            employee.PasswordHash = passHash;
            employee.PasswordSalt = passSalt;

            var state = await _unitOfWork.AuthDAL.Register(employee);

            return Result<bool>.Success(state);
        }

        public async Task<Result<EmployeeLoginDTO>> SetPassword(EmployeeLoginDTO employeeLoginDTO)
        {         
            byte[] passHash, passSalt;
            HashingHelper.CreatePassword(employeeLoginDTO.Password, out passHash, out passSalt);
            
            var employeeCheck = await _unitOfWork.AuthDAL.SetPassword(new Employee { Email = employeeLoginDTO.Email, PasswordHash = passHash, PasswordSalt = passSalt });
            if (!employeeCheck)
                throw new Exception("Bir sorun oluştu!");

            return Result<EmployeeLoginDTO>.Success(employeeLoginDTO);
        }
    }
}
