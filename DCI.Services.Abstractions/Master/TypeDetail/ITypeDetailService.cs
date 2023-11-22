using DCI.Domain.Entities.Base;
using DCI.Domain.Entities.Master.TypeDetail;

namespace DCI.Services.Abstractions.Master.TypeDetail
{
    public interface ITypeDetailService
    {
        #region TypeDetail                                                                              
        Task<ResponseModel> GetTypeDetailAsync(CancellationToken cancellationToken);
        Task<ResponseModel> GetTypeDetailByIdAsync(int inputparameters, CancellationToken cancellationToken);
        Task<ResponseModel> GetTypeDetailByMasterIdAsync(TypeDetailByTypeMasterReadOnlyEntity inputparameters, CancellationToken cancellationToken);
        Task<ResponseModel> SaveTypeDetailAsync(TypeDetailEntity inputparameters, CancellationToken cancellationToken);
        Task<ResponseModel> UpdateTypeDetailAsync(TypeDetailEntity inputparameters, CancellationToken cancellationToken);
        Task<ResponseModel> DeleteTypeDetailAsync(int inputparameters, CancellationToken cancellationToken);
        #endregion
    }
}
