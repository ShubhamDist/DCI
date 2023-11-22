using DCI.Domain.Entities.Base;
using DCI.Domain.Entities.Master.Module;

namespace DCI.Services.Abstractions.Master.Module
{
    public interface IModuleService
    {
        #region Module                                                                                                                  
        Task<ResponseModel> GetModuleAsync(CancellationToken cancellationToken);
        Task<ResponseModel> GetModuleByIdAsync(int inputparameters, CancellationToken cancellationToken);
        Task<ResponseModel> SaveModuleAsync(ModuleEntity inputparameters, CancellationToken cancellationToken);
        Task<ResponseModel> UpdateModuleAsync(ModuleEntity inputparameters, CancellationToken cancellationToken);
        Task<ResponseModel> DeleteModuleAsync(int inputparameters, CancellationToken cancellationToken);
        #endregion
    }
}