namespace AdvanceUI.DTOs.BusinessUnit
{
    public record BusinessUnitSelectDTO
    {
        public int Id { get; set; }
        public string BusinessUnitName { get; set; }
        public string BusinessUnitDescription { get; set; }
    }
}
