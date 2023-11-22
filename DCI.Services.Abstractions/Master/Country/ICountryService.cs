using DCI.Domain.Entities.Base;
using DCI.Domain.Entities.Master.Country;

namespace DCI.Services.Abstractions.Master.Country
{
    public interface ICountryService
    {
        #region Country                                                                                                                  
        Task<ResponseModel> GetCountryAsync(CancellationToken cancellationToken);
        Task<ResponseModel> GetCountryByIdAsync(int inputparameters, CancellationToken cancellationToken);
        Task<ResponseModel> SaveCountryAsync(CountryEntity inputparameters, CancellationToken cancellationToken);
        Task<ResponseModel> UpdateCountryAsync(CountryEntity inputparameters, CancellationToken cancellationToken);
        Task<ResponseModel> DeleteCountryAsync(int inputparameters, CancellationToken cancellationToken);
        #endregion
    }
}