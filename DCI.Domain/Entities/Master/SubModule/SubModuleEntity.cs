using DCI.Domain.Entities.Base;

namespace DCI.Domain.Entities.Master.SubModule
{
    public class SubModuleEntity : BaseEntity
    {
        public int SubModuleId { get; set; }
        public int ModuleId { get; set; }
        public required string SubModuleName { get; set; }
        public required string LogicalName { get; set; }
    }
}
