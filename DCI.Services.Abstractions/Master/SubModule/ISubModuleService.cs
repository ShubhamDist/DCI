using DCI.Domain.Entities.Base;
using DCI.Domain.Entities.Master.SubModule;

namespace DCI.Services.Abstractions.Master.SubModule
{
    public interface ISubModuleService
    {
        #region SubModule                                                                                                                  
        Task<ResponseModel> GetSubModuleAsync(CancellationToken cancellationToken);
        Task<ResponseModel> GetSubModuleByIdAsync(int inputparameters, CancellationToken cancellationToken);
        Task<ResponseModel> GetSubModuleByModuleIdAsync(int inputparameters, CancellationToken cancellationToken);
        Task<ResponseModel> SaveSubModuleAsync(SubModuleEntity inputparameters, CancellationToken cancellationToken);
        Task<ResponseModel> UpdateSubModuleAsync(SubModuleEntity inputparameters, CancellationToken cancellationToken);
        Task<ResponseModel> DeleteSubModuleAsync(int inputparameters, CancellationToken cancellationToken);
        #endregion
    }
}