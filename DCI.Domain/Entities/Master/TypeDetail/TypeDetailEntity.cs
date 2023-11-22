using DCI.Domain.Entities.Base;

namespace DCI.Domain.Entities.Master.TypeDetail
{
    public class TypeDetailEntity : BaseEntity
    {
        public int? TypeDetailId { get; set; }
        public int TypeMasterId { get; set; }
        public required string TypeDetailName { get; set; }
        public required string LogicalCode { get; set; }
    }
}
