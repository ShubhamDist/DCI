namespace DCI.Domain.Entities.Base
{
    public class BaseEntity
    {
        public DateTime? CreatedOn { get; set; } = DateTime.Now;
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; } 
        public int? ModifiedBy { get; set; }
        public string? InformationSource { get; set; }
    }
}
