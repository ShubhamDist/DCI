using DCI.Domain.Entities.Base;
using DCI.Domain.Entities.Master.SubModule;

namespace DCI.Domain.Repositories.Master.SubModule
{
    public interface ISubModuleRepository
    {
        #region SubModule                                                                                                                  
        Task<IEnumerable<SubModuleReadOnlyEntity>> GetSubModuleAsync(CancellationToken cancellationToken);
        Task<IEnumerable<SubModuleReadOnlyEntity>> GetSubModuleByIdAsync(int inputparameters, CancellationToken cancellationToken);
        Task<IEnumerable<SubModuleReadOnlyEntity>> GetSubModuleByModuleIdAsync(int inputparameters, CancellationToken cancellationToken);
        Task<DBResponseEntity> SaveSubModuleAsync(SubModuleEntity inputparameters, CancellationToken cancellationToken);
        Task<DBResponseEntity> UpdateSubModuleAsync(SubModuleEntity inputparameters, CancellationToken cancellationToken);
        Task<DBResponseEntity> DeleteSubModuleAsync(int inputparameters, CancellationToken cancellationToken);
        #endregion
    }
}