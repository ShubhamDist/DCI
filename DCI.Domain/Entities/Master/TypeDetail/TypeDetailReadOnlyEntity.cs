namespace DCI.Domain.Entities.Master.TypeDetail
{
    public class TypeDetailReadOnlyEntity
    {
        public int TypeDetailId { get; set; }
        public string? TypeDetailName { get; set; }
        public int SequenceNo { get; set; }
        public int TypeMasterId { get; set; }
        public string? TypeMasterName { get; set; }
        public string? TypeMasterLogicalCode { get; set; }
        public List<TypeMsterResponseEntity> typeMsterResponseEntity { get; set; }
    }
    public class TypeMsterResponseEntity
    {
        public int TypeMasterId { get; set; }
        public string? TypeMasterName { get; set; }
        public List<TypeDetailResponseEntity> typeDetailResponseEntity { get; set; }

    }   
    public class TypeDetailResponseEntity
    {
        public int TypeDetailId { get; set; }
        public string? TypeDetailName { get; set; }
    }
    public class TypeDetailByTypeMasterReadOnlyEntity
    {
        public int[] TypeMasterId { get; set; } = new int[0];
    }
}
