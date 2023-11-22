
using DCI.Domain.Entities.Base;
using DCI.Domain.Entities.Master.City;

namespace DCI.Services.Abstractions.Master.City
{
    public interface ICityService
    {
        #region City                                                                                                                  
        Task<ResponseModel> GetCityAsync(CancellationToken cancellationToken);
        Task<ResponseModel> GetCityByIdAsync(int inputparameters, CancellationToken cancellationToken);
        Task<ResponseModel> GetCityByStateIdAsync(int inputparameters, CancellationToken cancellationToken);
        Task<ResponseModel> SaveCityAsync(CityEntity inputparameters, CancellationToken cancellationToken);
        Task<ResponseModel> UpdateCityAsync(CityEntity inputparameters, CancellationToken cancellationToken);
        Task<ResponseModel> DeleteCityAsync(int inputparameters, CancellationToken cancellationToken);
        #endregion
    }
}