using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAPI.DTOs.Employee
{
    public record EmployeeRegisterDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
        public int BusinessUnitId { get; set; }
        public int EmployeeId { get; set; }
        public int TitleId { get; set; }
    }
}
