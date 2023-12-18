using AdvanceUI.DTOs.BusinessUnit;
using AdvanceUI.DTOs.Title;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceUI.DTOs.Employee
{
    public record EmployeeSelectDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int? BusinessUnitId { get; set; }
        public int? TitleId { get; set; }
        public string Token { get; set; }
        public string NewPassword { get; set; }

		public string ResetToken { get; set; }
		public DateTime? ResetTokenExpiration { get; set; }

		public virtual EmployeeSelectDTO UpperEmployee { get; set; }
        public virtual BusinessUnitSelectDTO BusinessUnit { get; set; }
        public virtual TitleSelectDTO Title { get; set; }
    }
}
