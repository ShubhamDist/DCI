namespace DCI.Domain.Entities.Master.Module
{
    public class ModuleReadOnlyEntity
    {
        public int ModuleId { get; set; }
        public required string ModuleName { get; set; }
    }
}
