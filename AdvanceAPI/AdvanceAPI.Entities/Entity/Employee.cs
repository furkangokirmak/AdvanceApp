using System;
using System.Collections.Generic;

namespace AdvanceAPI.Entities.Entity
{
    public class Employee : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public int? BusinessUnitId { get; set; }
        public int? TitleId { get; set; }
        public int? UpperEmployeeId { get; set; }

		public string ResetToken { get; set; }
		public DateTime? ResetTokenExpiration { get; set; }

		public virtual BusinessUnit BusinessUnit { get; set; }
        public virtual Title Title { get; set; }
        public virtual Employee UpperEmployee { get; set; }
		public virtual ICollection<Advance> Advances { get; set; }
		public virtual ICollection<AdvanceHistory> AdvanceHistories { get; set; }
        public virtual ICollection<EmployeeProject> EmployeeProjects { get; set; }
        public virtual ICollection<Employee> InverseUpperEmployee { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<Receipt> Receipts { get; set; }
    }
}
