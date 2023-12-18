namespace AdvanceAPI.DTOs.Employee
{
    public record EmployeeRegisterDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
        public int BusinessUnitId { get; set; }
        public int UpperEmployeeId { get; set; }
        public int TitleId { get; set; }
    }
}
