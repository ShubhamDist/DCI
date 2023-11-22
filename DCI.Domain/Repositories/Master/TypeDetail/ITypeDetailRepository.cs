using DCI.Domain.Entities.Base;
using DCI.Domain.Entities.Master.TypeDetail;

namespace DCI.Domain.Repositories.Master.TypeDetail
{
    public interface ITypeDetailRepository
    {
        #region Officer                                                                                 
        Task<IEnumerable<TypeDetailReadOnlyEntity>> GetTypeDetailAsync(CancellationToken cancellationToken);
        Task<IEnumerable<TypeDetailReadOnlyEntity>> GetTypeDetailByIdAsync(int inputparameters, CancellationToken cancellationToken);
        Task<IEnumerable<TypeDetailReadOnlyEntity>> GetTypeDetailByMasterIdAsync(TypeDetailByTypeMasterReadOnlyEntity inputparameters, CancellationToken cancellationToken);
        Task<DBResponseEntity> SaveTypeDetailAsync(TypeDetailEntity inputparameters, CancellationToken cancellationToken);
        Task<DBResponseEntity> UpdateTypeDetailAsync(TypeDetailEntity inputparameters, CancellationToken cancellationToken);
        Task<DBResponseEntity> DeleteTypeDetailAsync(int inputparameters, CancellationToken cancellationToken);
        #endregion
    }
}
