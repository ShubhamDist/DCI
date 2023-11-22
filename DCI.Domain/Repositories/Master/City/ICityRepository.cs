
using DCI.Domain.Entities.Base;
using DCI.Domain.Entities.Master.City;

namespace DCI.Domain.Repositories.Master.City
{
    public interface ICityRepository
    {
        #region City                                                                                                                  
        Task<IEnumerable<CityReadOnlyEntity>> GetCityAsync(CancellationToken cancellationToken);
        Task<IEnumerable<CityReadOnlyEntity>> GetCityByIdAsync(int inputparameters, CancellationToken cancellationToken);
        Task<IEnumerable<CityReadOnlyEntity>> GetCityByStateIdAsync(int inputparameters, CancellationToken cancellationToken);
        Task<DBResponseEntity> SaveCityAsync(CityEntity inputparameters, CancellationToken cancellationToken);
        Task<DBResponseEntity> UpdateCityAsync(CityEntity inputparameters, CancellationToken cancellationToken);
        Task<DBResponseEntity> DeleteCityAsync(int inputparameters, CancellationToken cancellationToken);
        #endregion
    }
}