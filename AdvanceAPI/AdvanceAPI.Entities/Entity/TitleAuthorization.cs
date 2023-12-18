namespace AdvanceAPI.Entities.Entity
{
    public class TitleAuthorization : BaseEntity
    {
        public int TitleId { get; set; }
        public int AuthorizationId { get; set; }
        public int PageId { get; set; }

        public virtual Authorization Authorization { get; set; }
        public virtual Page Page { get; set; }
        public virtual Title Title { get; set; }
    }
}
