namespace AdvanceAPI.DTOs.Page
{
    public record PageSelectDTO
    {
        public int PageId { get; set; }
        public string PageName { get; set; }
        public string Path { get; set; }
		public string Icon { get; set; }
	}
}
